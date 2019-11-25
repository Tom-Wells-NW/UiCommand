using UiCommand.Models;

namespace UiCommand.ViewModels
{
	public interface IDeviceViewModel
	{
		IDevice Device { get; }
		INamedCommand DisableDeviceCommand { get; }
		INamedCommand EnableDeviceCommand { get; }
		INamedCommand PingDeviceCommand { get; }
	}
}