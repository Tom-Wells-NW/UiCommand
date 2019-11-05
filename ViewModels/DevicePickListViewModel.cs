using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UiCommand.Models;

namespace UiCommand.ViewModels
{
	public class DevicePickListViewModel : ViewModelBase, IDevicePickListViewModel
	{

		private DeviceViewModelCollection _devices;
		private IDeviceViewModel _selectedDevice;

		public DevicePickListViewModel() { }


		public DeviceViewModelCollection Devices
		{
			get { return _devices; }
			set { Set(ref _devices, value); }
		}

		public IDeviceViewModel SelectedDevice
		{
			get { return _selectedDevice; }
			set { Set(ref _selectedDevice, value); }
		}
	}
}
