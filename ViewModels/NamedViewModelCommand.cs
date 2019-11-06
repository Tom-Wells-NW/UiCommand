using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;

namespace UiCommand.ViewModels
{

	public class NamedViewModelCommand : ViewModelBase, ICommand
	{
		private string _commandKey;
		private string _commandName;
		private Predicate<object> _canExecute;
		private Action<object> _execute;

		public NamedViewModelCommand(string commandName, Action<object> execute, Predicate<object> canExecute)
		{
			_commandName = commandName;
			_execute = execute;
			_canExecute = canExecute;
		}

		public NamedViewModelCommand(string commandName, Action<object> execute)
			: this(commandName, execute, null)
		{
			//ctor that assumes CanExecute is true
		}

		public NamedViewModelCommand(string commandName, Action execute)
			: this(commandName, _ => execute(), null)
		{
			//ctor that assumes CanExecute is true
		}

		public NamedViewModelCommand(string commandName, Action execute, Func<bool> canExecute)
			: this(commandName, _ => execute(), _ => canExecute())
		{
		}

		public string CommandName
		{
			get { return _commandName; }
			set { Set(ref _commandName, value); }
		}

		public bool CanExecute(object parameter)
		{
			if (_canExecute == null)
			{
				return true;
			}

			return _canExecute(parameter);
		}


		public event EventHandler CanExecuteChanged
		{
			add { System.Windows.Input.CommandManager.RequerySuggested += value; }
			remove { System.Windows.Input.CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute()
		{
			return _canExecute(null);
		}

		public void Execute()
		{
			_execute(null);
		}

		public void Execute(object parameter)
		{
			_execute(parameter);
		}
	}

}
