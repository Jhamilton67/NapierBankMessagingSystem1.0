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
    public class QuarantineListViewModel : BaseViewModel
    {// Getters and setters for the Buttons on the Quaratine Page
        #region Textbox Variables
        public string QDataTextBox { get; private set; }
        #endregion
        #region Button Variables
        public string ClearQuarantineDataFromTextBoxesButton { get; private set; }
        #endregion
        #region Button IComannd
        public ICommand ClearQuarantineDataFromTextBoxesButtonCommand { get; private set; }
        #endregion
        #region ObservableColletion 
         //Observable collection which holds all the data from the CSV file 
        public ObservableCollection<Email> Incidents { get; set; }
        #endregion
        #region Contructor
        public QuarantineListViewModel()
        {//Clearing the Textbox to make sure they are always empty when the program loads.
            QDataTextBox = string.Empty;
             //The label  button.
            ClearQuarantineDataFromTextBoxesButton = "Clear Data";
            //private click helper linking to Action Method in relayCommands
            ClearQuarantineDataFromTextBoxesButtonCommand = new RelayCommands(ClearQuarantineDataFromTextBoxesButtonClick);

              //Loads in the data from the CSV file in the load class into the constructor 
            //so it runs when the page is opended.
            LoadFromFile load = new LoadFromFile();
            if (!load.DataFromCSVEmail())
            {
                Incidents = new ObservableCollection<Email>();
            }
            else
            {
                Incidents = new ObservableCollection<Email>(load.EmailData);
            }
        }
        #endregion
        #region Private Click Helper
         //Asks the user if they would like to save the data from what they are viewing.
        private void ClearQuarantineDataFromTextBoxesButtonClick()
        {
            QDataTextBox = string.Empty;

            OnChnaged(nameof(QDataTextBox));

            MessageBox.Show("Data Cleared");
        }
        #endregion
    }
}
