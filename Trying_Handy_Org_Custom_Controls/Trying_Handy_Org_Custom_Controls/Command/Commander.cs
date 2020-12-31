using System;
using System.Windows.Input;

namespace Trying_Handy_Org_Custom_Controls.Command
{
    public class Commander : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public Commander(Action execute) : this(execute, () => true) { }

        public Commander(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}