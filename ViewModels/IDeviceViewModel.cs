using UiCommand.Models;

namespace UiCommand.ViewModels
{
	public interface IDeviceViewModel
	{
		IDevice Device { get; }
		NamedCommand DisableDeviceCommand { get; }
		NamedCommand EnableDeviceCommand { get; }
		NamedCommand PingDeviceCommand { get; }
	}
}