using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UiCommand.ViewModels
{
	public class DeviceViewModelCollection : ObservableCollection<IDeviceViewModel>, ICollection<IDeviceViewModel>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		public DeviceViewModelCollection() : base() { }

		public DeviceViewModelCollection(List<IDeviceViewModel> list) : base(list) { }

		public DeviceViewModelCollection(IEnumerable<IDeviceViewModel> collection) : base(collection) { }
	}
}
