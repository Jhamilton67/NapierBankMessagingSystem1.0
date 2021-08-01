using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged//Notifys the object that the property has chnaged in the User interface
    {
        public event PropertyChangedEventHandler PropertyChanged;  

        public void OnChnaged(string name)//INotifyPropertychnaged Method
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
