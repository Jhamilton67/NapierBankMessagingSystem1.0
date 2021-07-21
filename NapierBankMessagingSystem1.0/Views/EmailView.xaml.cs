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
    /// Interaction logic for EmailView.xaml
    /// </summary>
    public partial class EmailView : UserControl
    {
        public EmailView()
        {
            InitializeComponent();

            this.DataContext = new EmailViewModel();
        }

        private void EmailComBoxData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Email EmailData1 = EmailComBoxData.SelectedItem as Email;
            MessageBoxEmailSender.Text = EmailData1.EmailSymbol;
            MessageBoxEmailSubject.Text = EmailData1.Subject;
            MessageBoxEmailText.Text = EmailData1.MessageText;

            MessageBox.Show(EmailComBoxData.SelectedItem.ToString());
            EmailData1.ToString();

        }
    }
}
