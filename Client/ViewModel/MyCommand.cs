using System;
using System.Windows.Input;

namespace Calculator.Client.ViewModel {
    public class MyCommand : ICommand {
        private readonly Action action;
        private readonly Func<bool> canExecute;

        public MyCommand(Action action, Func<bool> canExecute = null) {
            this.action = action;
            this.canExecute = canExecute ?? (() => true) ;
        }

        public bool CanExecute(object parameter) {
            return canExecute();
        }

        public void Execute(object parameter) {
            action();
        }

        public event EventHandler CanExecuteChanged;
    }
    
    public class MyCommand<T> : ICommand {
        private readonly Action<T> action;
        private readonly Func<T, bool> canExecute;

        public MyCommand(Action<T> action, Func<T, bool> canExecute = null) {
            this.action = action;
            this.canExecute = canExecute ?? (_ => true) ;
        }

        public bool CanExecute(object parameter) {
            return canExecute((T)parameter);
        }

        public void Execute(object parameter) {
            action((T)parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}