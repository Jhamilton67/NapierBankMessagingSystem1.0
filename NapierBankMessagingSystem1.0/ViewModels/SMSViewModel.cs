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
    public class SMSViewModel : BaseViewModel
    {
       // Getters and setters for the Trending list, SIR List and mentions list. 
        #region TextboxVariables 
        public string MessageBodyTextBox { get; private set; }
        public string MessageHeaderTextBox { get; private set; }
        #endregion
        #region ButtonVariable
        public string ClearDataFromTextBoxesButton { get; private set; }
        #endregion

        #region ICommand 
        public ICommand ClearDataFromTextBoxesButtonCommand { get; private set; }
        #endregion
        #region ObservableCollection for SMS
        public ObservableCollection<SMS> SMS { get; set; }
        #endregion

        #region Constructior
        public SMSViewModel()
        {
            MessageBodyTextBox = string.Empty;
            MessageHeaderTextBox = string.Empty;

            ClearDataFromTextBoxesButton = "Clear Data";

            ClearDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);


            LoadFromFile loaddata = new LoadFromFile();
            if(!loaddata.DataFromCSVSMS())
            {
                SMS = new ObservableCollection<SMS>();
            }
            else
            {
                SMS = new ObservableCollection<SMS>(loaddata.SMSData);
            }
        }
        #endregion

        #region Private Click Helper
        private void ClearDataFromTextBoxesButtonClick()
        {
            MessageBodyTextBox = string.Empty;
            MessageHeaderTextBox = string.Empty;

            OnChnaged(nameof(MessageBodyTextBox));
            OnChnaged(nameof(MessageHeaderTextBox));

            MessageBox.Show("Data Cleared");
        }
        #endregion
    }
}
