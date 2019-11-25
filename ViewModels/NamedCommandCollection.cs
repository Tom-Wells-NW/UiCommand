using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UiCommand.ViewModels
{
	public class NamedCommandCollection : ObservableCollection<INamedCommand>, ICollection<INamedCommand>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		public NamedCommandCollection() : base() { }

		public NamedCommandCollection(List<INamedCommand> list) : base(list) { }

		public NamedCommandCollection(IEnumerable<INamedCommand> collection) : base(collection) { }
	}
}
