using NapierBankMessagingSystem1._0.Commands;
using NapierBankMessagingSystem1._0.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NapierBankMessagingSystem1._0.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {// Getters and setters for the Buttons on the MainWindow Page
        #region Button Variables
        public string ViewSMSButton { get; private set; }
        public string ViewEmailButton { get; private set; }
        public string ViewTwitterButton { get; private set; }
        public string IncidentsReportsButton { get; private set; }
        public string QuarantineListButton { get; private set; }
        public string ExitButton { get; private set; }
        #endregion
        #region Button ICommand's
        public ICommand SMSButtonCommand { get; private set; }
        public ICommand EmailButtonCommand { get; private set; }
        public ICommand TwitterButtonCommand { get; private set; }
        public ICommand IncidentReportsButtonCommand { get; private set; }
        public ICommand QuarantineListButtonCommand { get; private set; }
        public ICommand ExitButtonCommand { get; private set; }
        #endregion

        #region User Content Control Binding
        public UserControl ContentControlBinding {get; private set;}
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            ViewSMSButton = "ViewSMS";
            ViewEmailButton = "ViewEmail";
            ViewTwitterButton = "ViewTwitter";
            IncidentsReportsButton = "Incident Reports";
            QuarantineListButton = "Quarantine List";
            ExitButton = "Exit";

            SMSButtonCommand = new RelayCommands(SMSButtonClick);
            EmailButtonCommand = new RelayCommands(EmailButtonClick);
            TwitterButtonCommand = new RelayCommands(TwitterButtonClick);
            IncidentReportsButtonCommand = new RelayCommands(IncidentReportsButtonClick);
            QuarantineListButtonCommand = new RelayCommands(QuarantineListButtonClick);
            ExitButtonCommand = new RelayCommands(ExitButtonClick);

            ContentControlBinding = new DefaultView(); 
        }

        #endregion

        #region Private Click Helpers
        private void SMSButtonClick()
        {
            ContentControlBinding = new SMSView();
            OnChnaged(nameof(ContentControlBinding));
        }

        private void EmailButtonClick()
        {
            ContentControlBinding = new EmailView();
            OnChnaged(nameof(ContentControlBinding));
        }

        private void TwitterButtonClick()
        {
            ContentControlBinding = new TwitterView();
            OnChnaged(nameof(ContentControlBinding));
        }

        private void IncidentReportsButtonClick()
        {
            ContentControlBinding = new IncidentsReportView();
            OnChnaged(nameof(ContentControlBinding));
        }

        private void QuarantineListButtonClick()
        {
            ContentControlBinding = new QuarantineListView();
            OnChnaged(nameof(ContentControlBinding));
        }

        private void ExitButtonClick()
        {
            MessageBoxResult message = MessageBox.Show("Do you want to Close this session", "Confirmation", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

            if (message == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else _ = message == MessageBoxResult.No;
            {
                
            };
        }
        #endregion
    }
}
