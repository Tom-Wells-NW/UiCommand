using UiCommand.Models;

namespace UiCommand.ViewModels
{
	public interface IDevicePickListViewModel
	{
		DeviceViewModelCollection Devices { get; set; }
		IDeviceViewModel SelectedDevice { get; set; }
	}
}