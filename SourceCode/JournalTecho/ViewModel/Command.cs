using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace JournalTecho.ViewModel
{
    //公共命令类
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        //委托命令
        private Action<object> EAction;

        public Command(Action<object> action)
        {
            EAction = action;   //命令传入
        }

        //校验命令
        public bool CanExecute(object parameter)
        {
            return true;
        }

        //自行命令
        public void Execute(object parameter)
        {
            EAction?.Invoke(parameter); //自行命令
        }
    }
}
