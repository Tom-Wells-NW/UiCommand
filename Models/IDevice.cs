namespace UiCommand.Models
{
	public interface IDevice
	{
		int DeviceId { get; set; }
		string DeviceName { get; set; }
		bool IsOnLine { get; set; }
		void PingDevice();
		void DisableDevice();
		void EnableDevice();

	}
}