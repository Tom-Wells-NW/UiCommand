﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UiCommand.ViewModels
{
	public class NamedViewModelCommandCollection : ObservableCollection<NamedViewModelCommand>, ICollection<NamedViewModelCommand>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		public NamedViewModelCommandCollection() : base() { }

		public NamedViewModelCommandCollection(List<NamedViewModelCommand> list) : base(list) { }

		public NamedViewModelCommandCollection(IEnumerable<NamedViewModelCommand> collection) : base(collection) { }
	}
}
