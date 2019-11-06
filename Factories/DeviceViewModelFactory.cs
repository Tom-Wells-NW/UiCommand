using UiCommand.Models;
using UiCommand.ViewModels;

namespace UiCommand.Factories
{
	public class DeviceViewModelFactory : IDeviceViewModelFactory
	{
		public IDeviceViewModel Create(IDevice device)
		{
			var result = new DeviceViewModel(device);
			return result;
		}
	}
}
