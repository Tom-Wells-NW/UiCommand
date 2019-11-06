using System.Collections.Generic;
using UiCommand.Models;
using UiCommand.ViewModels;

namespace UiCommand.Factories
{
	public class DeviceViewModelCollectionFactory : IDeviceViewModelCollectionFactory
	{
		private IDeviceViewModelFactory _deviceViewModelFactory;
		public DeviceViewModelCollectionFactory(IDeviceViewModelFactory deviceViewModelFactory)
		{
			_deviceViewModelFactory = deviceViewModelFactory;
		}
		public DeviceViewModelCollection Create(IEnumerable<IDevice> devices)
		{
			var result = new DeviceViewModelCollection();
			foreach (var device in devices)
			{
				result.Add(_deviceViewModelFactory.Create(device));
			}
			return result;
		}

		public DeviceViewModelCollection Create(IEnumerable<IDeviceViewModel> deviceViewModels)
		{
			var result = new DeviceViewModelCollection();
			foreach (var deviceViewModel in deviceViewModels)
			{
				result.Add(deviceViewModel);
			}
			return result;
		}
	}
}
