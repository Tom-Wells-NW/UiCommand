using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace UiCommand.Models
{
	public class Device : ObservableObject, IDevice
	{
		private int _deviceId;
		public int DeviceId
		{
			get { return _deviceId; }
			set { Set(ref _deviceId, value); }
		}

		private string _deviceName;
		public string DeviceName
		{
			get { return _deviceName; }
			set { Set(ref _deviceName, value); }
		}

		private bool _isOnLine;
		public bool IsOnLine
		{
			get { return _isOnLine; }
			set { Set(ref _isOnLine, value); }
		}

		public void PingDevice()
		{
			Console.WriteLine($"Pinging device named: {DeviceName}...");
		}

		public void DisableDevice()
		{
			Console.WriteLine($"Disabling device named: {DeviceName}...");
			IsOnLine = false;
		}

		public void EnableDevice()
		{
			Console.WriteLine($"Enabling device named: {DeviceName}...");
			IsOnLine = true;
		}

		public override string ToString()
		{
			return DeviceName;
		}
	}
}
