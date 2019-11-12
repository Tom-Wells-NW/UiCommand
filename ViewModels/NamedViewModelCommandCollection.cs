using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UiCommand.ViewModels
{
	public class NamedViewModelCommandCollection : ObservableCollection<NamedCommand>, ICollection<NamedCommand>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		public NamedViewModelCommandCollection() : base() { }

		public NamedViewModelCommandCollection(List<NamedCommand> list) : base(list) { }

		public NamedViewModelCommandCollection(IEnumerable<NamedCommand> collection) : base(collection) { }
	}
}
