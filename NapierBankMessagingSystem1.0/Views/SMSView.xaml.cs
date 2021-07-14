using NapierBankMessagingSystem1._0.Models;
using NapierBankMessagingSystem1._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NapierBankMessagingSystem1._0.Views
{
    /// <summary>
    /// Interaction logic for SMSView.xaml
    /// </summary>
    public partial class SMSView : UserControl
    {
        public SMSView()
        {
            InitializeComponent();

            this.DataContext = new SMSViewModel();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SMS smsdata1 = ComBoxData.SelectedItem as SMS;
            MessageSendertxt.Text = smsdata1.Sender;
            MessageBodytxt.Text = smsdata1.MessageText;
        }
    }
}
