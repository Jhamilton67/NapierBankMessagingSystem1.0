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
        public string SaveEmailDataFromTextBoxesButton { get; private set; }
        #endregion

        #region ICommand 
        public ICommand ClearEmailDataFromTextBoxesButtonCommand { get; private set; }
        public ICommand SaveEmailDataFromTextBoxesButtonCommand { get; private set; }
        #endregion

        public ObservableCollection<Email> Email { get; set; }

        #region Constructor
        public EmailViewModel()
        {
            EmailSubjectTextBox = string.Empty;
            EmailSenderTextBox = string.Empty;
            EmailBodyTextBox = string.Empty;

            ClearEmailDataFromTextBoxesButton = "Clear Data";
            SaveEmailDataFromTextBoxesButton = "Save Data";

            ClearEmailDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);
            SaveEmailDataFromTextBoxesButtonCommand = new RelayCommands(SaveEmailDataFromTextBoxesButtonClick);
           
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

        private void SaveEmailDataFromTextBoxesButtonClick()
        {

            MessageBoxResult message = MessageBox.Show("Do you want to Save the Email data", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message == MessageBoxResult.Yes)
            {
                System.IO.File.WriteAllText(@"C:\Users\user\Desktop\Year 3 of Uni\Software Development\SaveDataFolder\NapierBankSaveDataEmail", string.Empty);

                EmailSenderTextBox = string.Empty;
                EmailBodyTextBox = string.Empty;
                EmailSubjectTextBox = string.Empty;

                OnChnaged(nameof(EmailBodyTextBox));
                OnChnaged(nameof(EmailSubjectTextBox));
                OnChnaged(nameof(EmailSenderTextBox));

               
            }
            else _ = message == MessageBoxResult.No;
            {

            };
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
