using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UiCommand.Models
{
	public class DeviceCollection : ObservableCollection<IDevice>, ICollection<IDevice>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		public DeviceCollection() : base() { }

		public DeviceCollection(List<IDevice> list) : base(list) { }

		public DeviceCollection(IEnumerable<IDevice> collection) : base(collection) { }
	}
}
