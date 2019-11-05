using UiCommand.Models;
using UiCommand.ViewModels;

namespace UiCommand.Factories
{
	public interface IDeviceViewModelFactory
	{
		IDeviceViewModel Create(IDevice device);
	}
}