using GalaSoft.MvvmLight;
using UiCommand.Models;

namespace UiCommand.ViewModels
{
	public class DeviceViewModel : ViewModelBase, IDeviceViewModel
	{
		public DeviceViewModel(IDevice device)
		{
			Device = device;
			CreateDeviceCommands();
		}

		private void CreateDeviceCommands()
		{
			PingDeviceCommand = new NamedCommand("Ping", _ => Device.PingDevice(), _ => CanExecuteDeviceCommand());
			DisableDeviceCommand = new NamedCommand("Disable", _ => Device.DisableDevice(), _ => CanExecuteDeviceCommand());
			EnableDeviceCommand = new NamedCommand(null, _ => Device.EnableDevice(), _ => CanExecuteDeviceCommand());
		}

		private IDevice _device;
		public IDevice Device
		{
			get { return _device; }
			private set { Set(ref _device, value); }
		}

		private bool CanExecuteDeviceCommand()
		{
			var result = Device != null;
			return result;
		}


		private NamedCommand _pingDeviceCommand;
		public NamedCommand PingDeviceCommand
		{
			get { return _pingDeviceCommand; }
			private set { Set(ref _pingDeviceCommand, value); }
		}

		private NamedCommand _disableDeviceCommand;
		public NamedCommand DisableDeviceCommand
		{
			get { return _disableDeviceCommand; }
			private set { Set(ref _disableDeviceCommand, value); }
		}

		private NamedCommand _enableDeviceCommand;
		public NamedCommand EnableDeviceCommand
		{
			get { return _enableDeviceCommand; }
			private set { Set(ref _enableDeviceCommand, value); }
		}
	}
}
