using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UiCommand.Services;

namespace UiCommand.ViewModels
{
	public class MainViewModel : ViewModelBase, IMainViewModel
	{
		private DeviceService _deviceService;
		public MainViewModel(DeviceService deviceService)
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
