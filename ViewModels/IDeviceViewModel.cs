using UiCommand.Models;

namespace UiCommand.ViewModels
{
	public interface IDeviceViewModel
	{
		IDevice Device { get; }
		NamedViewModelCommand DisableDeviceCommand { get; }
		NamedViewModelCommand EnableDeviceCommand { get; }
		NamedViewModelCommand PingDeviceCommand { get; }
	}
}