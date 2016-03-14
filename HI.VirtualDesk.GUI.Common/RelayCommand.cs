#region USING DIRECTIVES

using System;
using System.Windows.Input;

#endregion

namespace HI.VirtualDesk.GUI.Common
{
    internal class RelayCommand : ICommand
    {
        private readonly Action execute;

        private readonly Func<bool> canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public void Execute(object parameter)
        {
            execute();
        }

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        private void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}