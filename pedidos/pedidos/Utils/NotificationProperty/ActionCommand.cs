using System;
using System.Windows.Input;

namespace pedidos.Utils.NotificationProperty
{
    public class ActionCommand<T> : ICommand
    {
        Action<T> action;
        public ActionCommand(Action<T> action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter) => action((T)parameter);
    }
}
