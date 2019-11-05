using UiCommand.Models;
using UiCommand.ViewModels;

namespace UiCommand.Services
{
	public interface IDeviceService
	{
		DeviceCollection GetAllDevices();
		DevicePickListViewModel GetDevicePickList();
	}
}