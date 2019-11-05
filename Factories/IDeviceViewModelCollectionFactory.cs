using System.Collections.Generic;
using UiCommand.Models;
using UiCommand.ViewModels;

namespace UiCommand.Factories
{
	public interface IDeviceViewModelCollectionFactory
	{
		DeviceViewModelCollection Create(IEnumerable<IDevice> devices);
		DeviceViewModelCollection Create(IEnumerable<IDeviceViewModel> deviceViewModels);
	}
}