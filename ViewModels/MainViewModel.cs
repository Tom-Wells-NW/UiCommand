using GalaSoft.MvvmLight;
using UiCommand.Services;

namespace UiCommand.ViewModels
{
	public class MainViewModel : ViewModelBase, IMainViewModel
	{
		private IDeviceService _deviceService;
		public MainViewModel(IDeviceService deviceService)
		{
			_deviceService = deviceService;
			AvailableDevices = _deviceService.GetDevicePickList();
		}

		private IDevicePickListViewModel _availableDevices;
		public IDevicePickListViewModel AvailableDevices
		{
			get { return _availableDevices; }
			set { Set(ref _availableDevices, value); }
		}


	}
}
