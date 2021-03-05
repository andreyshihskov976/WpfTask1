﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTask1
{
    class DelegateCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
                return _canExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            if (_execute != null)
                _execute(parameter);
        }
        public DelegateCommand(Action<object> executeAction): this(executeAction, null) {}
        public DelegateCommand(Action<object> executeAction, Func<object,bool> canExecuteFunc)
        {
            _canExecute = canExecuteFunc;
            _execute = executeAction;
        }
    }
}
