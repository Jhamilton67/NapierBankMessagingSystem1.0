using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NapierBankMessagingSystem1._0.Commands
{
   public  class RelayCommands : ICommand 
   {
        private Action Action1;

        public event EventHandler CanExecuteChanged = (Sender, e) => { };

        public RelayCommands(Action action)
        {
            Action1 = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Action1();
        }
    }
}
