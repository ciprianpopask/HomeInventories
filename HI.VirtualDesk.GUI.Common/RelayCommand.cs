#region USING DIRECTIVES

using System;
using System.Windows.Input;

#endregion

namespace HI.VirtualDesk.GUI.Common
{
    /// <summary>
    /// Simple RelayCommand implementation
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private members and ctor

        private readonly Action<object> execute;
        private readonly Func<object,bool> canExecute;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="execute">Execution delegate</param>
        /// <param name="canExecute">Can execute validator delegate</param>
        public RelayCommand(Action<object> execute, Func<object,bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion

        /// <summary>
        /// Activates the CanExecuteChanged mechanism explicitly
        /// </summary>
        private void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        #region ICommand 

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            execute(parameter);
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
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

        #endregion
    }
}