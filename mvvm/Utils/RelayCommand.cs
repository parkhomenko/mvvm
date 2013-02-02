using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mvvm.Utils
{
    class RelayCommand : ICommand
    {
        Action execute = ExecuteMethod;
        Func<bool> executable = CanExecuteMethod;

        static void ExecuteMethod() { }
        static bool CanExecuteMethod() { return true; }

        public RelayCommand(Action execute) : this(execute, null) { }

        public RelayCommand(Action execute, Func<bool> executable)
        {
            if (execute != null) this.execute = execute;
            if (executable != null) this.executable = executable;
        }

        public void Execute(object parameter)
        {
            execute();
        }

        public bool CanExecute(object parameter)
        {
            return executable();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }
    }
}