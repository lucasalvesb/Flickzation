﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Flickzation.Core
{
    class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;  }
            remove { CommandManager.RequerySuggested -= value;  }
        }
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        _execute = execute; 

    }
}