using System;
using System.Windows.Input;

namespace UiCommand.ViewModels
{
    public interface INamedCommand : ICommand
    {
        string CommandName { get; set; }

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

        event EventHandler CanExecuteChanged;
        bool CanExecute();
        bool CanExecute(object parameter);
        void Execute();
        void Execute(object parameter);

 #pragma warning restore CS0108 // Member hides inherited member; missing new keyword
   }
}