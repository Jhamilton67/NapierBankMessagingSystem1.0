using NapierBankMessagingSystem1._0.Commands;
using NapierBankMessagingSystem1._0.Data;
using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NapierBankMessagingSystem1._0.ViewModels
{
    public class SMSViewModel : BaseViewModel
    {
        private readonly int length;

        //Getters and setters for the Buttons on the SMS page
        #region TextboxVariables 
        public string MessageBodyTextBox { get; private set; }
        public string MessageSenderTextBox { get; private set; }
        public string MessageHeaderTextBox { get; private set; }
        #endregion

        #region ButtonVariable
        public string ClearDataFromTextBoxesButton { get; private set; }
        public string SaveDataFromtextBoxesButton { get; private set; }
        #endregion

        #region ICommand 
        public ICommand ClearDataFromTextBoxesButtonCommand { get; private set; }
        public ICommand SaveDataFromtextBoxesButtonCommand { get; private set; }
        #endregion

        #region ObservableCollection for SMS
        //Observable collection which holds all the data from the CSV file 
        public ObservableCollection<SMS> SMSTextSpeak { get; set; }
        #endregion
         
        #region Constructor
        public SMSViewModel()
        {//Loads in the data from the CSV file in the load class into the constructor 
            //so it runs when the page is opended.
            LoadFromFile loaddata = new LoadFromFile();
            if (!loaddata.DataFromCSVSMS())
            {
                SMSTextSpeak = new ObservableCollection<SMS>();
            }
            else
            {
                SMSTextSpeak = new ObservableCollection<SMS>(loaddata.SMSData);
            }

            GenerateNumbers();
            //Clearing the Textboxes to make sure they are always empty when the program loads.
            MessageBodyTextBox = string.Empty;
            MessageSenderTextBox = string.Empty;
            MessageHeaderTextBox = string.Empty;
              //The label of each button.
            ClearDataFromTextBoxesButton = "Clear Data";
            SaveDataFromtextBoxesButton = "Save Data";
            //private click helpers linking to Action Method in relayCommands
            ClearDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);
            SaveDataFromtextBoxesButtonCommand = new RelayCommands(SaveDataFromtextBoxesButtonClick);

        }
        #endregion
        #region SenderGenerator
        //Used to Generate the Numbers for the Sender textbox
        public string GenerateNumbers()
        {
            var random = new Random();
            string a = string.Empty;
            for (int i = 0; i < length; i++)
            {
                a = string.Concat(a, random.Next(10).ToString());
            }
            return a;
        }
        #endregion

        #region Private Click Helper  SaveData

        private void SaveDataFromtextBoxesButtonClick()
        {
            MessageBoxResult message = MessageBox.Show("Do you want to Save the SMS data", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            string[] lines =
            {
                MessageHeaderTextBox, MessageSenderTextBox, MessageBodyTextBox
            };

            if (message == MessageBoxResult.Yes)
            {   //<Needs to fix the bug that actually lets the data be seen in the textfile
                //System.IO.File.WriteAllText(@"C:\Users\user\Desktop\Year 3 of Uni\Software Development\SaveDataFolder\NapierBankSaveDataSMS.txt", lines);

                //<This needs fixed
                //TextWriter text = new StreamWriter(@"C:\Users\user\Desktop\Year 3 of Uni\Software Development\SaveDataFolder\NapierBankSaveDataSMS.txt");
                //text.Close();

                MessageBodyTextBox = string.Empty;
                MessageSenderTextBox = string.Empty;
                MessageHeaderTextBox = string.Empty;

                OnChnaged(nameof(MessageHeaderTextBox));
                OnChnaged(nameof(MessageSenderTextBox));
                OnChnaged(nameof(MessageBodyTextBox));

            }
            else _ = message == MessageBoxResult.No;
            {

            };
        }
        #endregion
      
        #region Private Click Helper  ClearData
          //Clears all of the data from the textboxes
        private void ClearDataFromTextBoxesButtonClick()
        {
            MessageBodyTextBox = string.Empty;
            MessageSenderTextBox = string.Empty;
            MessageHeaderTextBox = string.Empty;

            OnChnaged(nameof(MessageBodyTextBox));
            OnChnaged(nameof(MessageSenderTextBox));
            OnChnaged(nameof(MessageHeaderTextBox));

            MessageBox.Show("Data Cleared");
        }
        #endregion
    }
}
