using Autofac;
using UiCommand.Factories;
using UiCommand.Services;

namespace UiCommand.ViewModels
{
	public class ViewModelLocator
	{
		public ViewModelLocator()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<DeviceViewModelFactory>()
                   .As<IDeviceViewModelFactory>()
                   .AsSelf();
			
            builder.RegisterType<DeviceViewModelCollectionFactory>()
                   .As<IDeviceViewModelCollectionFactory>()
                   .AsSelf();

			builder.RegisterType<MainViewModel>()
                   .As<IMainViewModel>()
                   .AsSelf();

			builder.RegisterType<DeviceService>()
                   .As<IDeviceService>().AsSelf()
                   .SingleInstance();

			//if (!ViewModelBase.IsInDesignModeStatic)
			//{
			//	//builder.RegisterModule<DataServiceModule>();
			//}
			//else
			//{
			//	//builder.RegisterType<Fss.HumanCapitalManager.DesignDataService.DesignDataService>().As<IDataService>().AsSelf();
			//}
			Container = builder.Build();
		}

		public IContainer Container { get; set; }

		public IMainViewModel MainViewModel => Container.Resolve<IMainViewModel>();

	}
}
