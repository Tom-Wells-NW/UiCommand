using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			PingDeviceCommand = new NamedViewModelCommand("Ping", _ => Device.PingDevice(), _ => CanExecuteDeviceCommand());
			DisableDeviceCommand = new NamedViewModelCommand("Disable", _ => Device.DisableDevice(), _ => CanExecuteDeviceCommand());
			EnableDeviceCommand = new NamedViewModelCommand("Enable", _ => Device.EnableDevice(), _ => CanExecuteDeviceCommand());
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


		private NamedViewModelCommand _pingDeviceCommand;
		public NamedViewModelCommand PingDeviceCommand
		{
			get { return _pingDeviceCommand; }
			private set { Set(ref _pingDeviceCommand, value); }
		}

		private NamedViewModelCommand _disableDeviceCommand;
		public NamedViewModelCommand DisableDeviceCommand
		{
			get { return _disableDeviceCommand; }
			private set { Set(ref _disableDeviceCommand, value); }
		}

		private NamedViewModelCommand _enableDeviceCommand;
		public NamedViewModelCommand EnableDeviceCommand
		{
			get { return _enableDeviceCommand; }
			private set { Set(ref _enableDeviceCommand, value); }
		}
	}
}
