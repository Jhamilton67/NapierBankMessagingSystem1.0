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
    {// Getters and setters for the Buttons on the EmailView Page
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
        //Observable collection which holds all the data from the CSV file 
        public ObservableCollection<Email> Email { get; set; }

        #region Constructor
        public EmailViewModel()
        {//Clearing the Textboxes to make sure they are always empty when the program loads.
            EmailSubjectTextBox = string.Empty;
            EmailSenderTextBox = string.Empty;
            EmailBodyTextBox = string.Empty;
            //The label of each button.
            ClearEmailDataFromTextBoxesButton = "Clear Data";
            SaveEmailDataFromTextBoxesButton = "Save Data";
            //private click helpers linking to Action Method in relayCommands
            ClearEmailDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);
            SaveEmailDataFromTextBoxesButtonCommand = new RelayCommands(SaveEmailDataFromTextBoxesButtonClick);
           
            //Loads in the data from the CSV file in the load class into the constructor 
            //so it runs when the page is opended.
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

         #region Private Click Helper save Data
        //Asks the user if they would like to save the data from what they are viewing.
        private void SaveEmailDataFromTextBoxesButtonClick()
        {

            MessageBoxResult message = MessageBox.Show("Do you want to Save the Email data", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message == MessageBoxResult.Yes)
            {
                //Add in Code for the Save command.

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

        #region Private Click Helper ClearData
        //Clears all of the data from the textboxes
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
