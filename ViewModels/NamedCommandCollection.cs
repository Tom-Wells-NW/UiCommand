using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UiCommand.ViewModels
{
	public class NamedCommandCollection : ObservableCollection<NamedCommand>, ICollection<NamedCommand>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		public NamedCommandCollection() : base() { }

		public NamedCommandCollection(List<NamedCommand> list) : base(list) { }

		public NamedCommandCollection(IEnumerable<NamedCommand> collection) : base(collection) { }
	}
}
