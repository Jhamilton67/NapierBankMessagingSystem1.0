using NapierBankMessagingSystem1._0.Commands;
using NapierBankMessagingSystem1._0.Data;
using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NapierBankMessagingSystem1._0.ViewModels
{
    public class EmailViewModel : BaseViewModel
    {
        #region TextBox Variables
        public string EmailSubjectTextBox { get; private set; }
        public string EmailSenderTextBox { get; private set; }
        public string EmailBodyTextBox { get; private set; }
        #endregion

        #region ButtonVariable
        public string ClearEmailDataFromTextBoxesButton { get; private set; }
        #endregion

        #region ICommand 
        public ICommand ClearEmailDataFromTextBoxesButtonCommand { get; private set; }
        #endregion

        public ObservableCollection<Email> Email { get; set; }

        #region Constructor
        public EmailViewModel()
        {
            EmailSubjectTextBox = string.Empty;
            EmailSenderTextBox = string.Empty;
            EmailBodyTextBox = string.Empty;

            ClearEmailDataFromTextBoxesButton = "Clear Data";

            ClearEmailDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);

            LoadFromFile load = new LoadFromFile();
            if (!load.DataFromCSVEmail())
            {
                Email = new ObservableCollection<Email>();
            }
            else
            {
                Email = new ObservableCollection<Email>(load.EmailData);
            }
        }
        #endregion

        #region Private Click Helper
        private void ClearDataFromTextBoxesButtonClick()
        {
            EmailSubjectTextBox = string.Empty;
            EmailSenderTextBox = string.Empty;
            EmailBodyTextBox = string.Empty;

            OnChnaged(nameof(EmailSubjectTextBox));
            OnChnaged(nameof(EmailSenderTextBox));
            OnChnaged(nameof(EmailBodyTextBox));
            
            MessageBox.Show("Data Cleared");
        }
        #endregion
    }
}
