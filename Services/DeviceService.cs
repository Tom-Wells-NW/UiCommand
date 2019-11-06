using System.Linq;
using UiCommand.Factories;
using UiCommand.Models;
using UiCommand.ViewModels;

namespace UiCommand.Services
{
	public class DeviceService : IDeviceService
	{
		private static DeviceCollection __allDevices = new DeviceCollection()
			{
				new Device { DeviceId = 100, DeviceName = "IXCoreServer" },
				new Device { DeviceId = 101, DeviceName = "RTR-PA-8.0.5" }
			};

		private IDeviceViewModelCollectionFactory _factory;
		public DeviceService(IDeviceViewModelCollectionFactory factory)
		{
			_factory = factory;
		}

		public DeviceCollection GetAllDevices()
		{
			var result = __allDevices;
			return result;
		}

		public DevicePickListViewModel GetDevicePickList()
		{
			var result = new DevicePickListViewModel();
			result.Devices = _factory.Create(__allDevices);
			if (result.Devices.Any()) result.SelectedDevice = result.Devices[0];
			return result;
		}
	}
}
