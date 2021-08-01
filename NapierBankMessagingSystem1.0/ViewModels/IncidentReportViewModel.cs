using NapierBankMessagingSystem1._0.Commands;
using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NapierBankMessagingSystem1._0.ViewModels
{
    public class IncidentReportViewModel : BaseViewModel
    {
        //Getters and setters for the Trending list, SIR List and mentions list. 
        #region TextboxVariables 
        public string TextBoxTrendingList { get; private set; }
        public string TextboxSIRList { get; private set; }
        public string TextBoxMentions { get; private set; }
        #endregion

        #region ButtonVariables 
        public string ClearDatafromTextBoxesButton { get; private set; }
        #endregion

        #region ButtonICommand's
        public ICommand ClearDatafromTextBoxesButtonCommand { get; private set; }
        #endregion

        #region Observable collection of data
        public ObservableCollection<Security> SecurityTypes { get; set; }
        #endregion

        #region Constructor
        public IncidentReportViewModel()
        { //The label  button.
            ClearDatafromTextBoxesButton = "Clear Data";
            //Clearing the Textbox to make sure they are always empty when the program loads.
            TextboxSIRList = string.Empty;
            TextBoxMentions = string.Empty;
             //private click helper linking to Action Method in relayCommands
            ClearDatafromTextBoxesButtonCommand = new RelayCommands(ClearDatafromTextBoxesButtonClick);
           
        }
        #endregion

        #region Private Click Helpers
        //Asks the user if they would like to save the data from what they are viewing.
        private void ClearDatafromTextBoxesButtonClick()
        {
            MessageBoxResult message = MessageBox.Show("Do you want to Clear the data", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message == MessageBoxResult.Yes)
            {
                TextBoxMentions = string.Empty;
                TextBoxMentions = string.Empty;

                OnChnaged(nameof(TextBoxMentions));
                OnChnaged(nameof(TextboxSIRList));
            }
            else _ = message == MessageBoxResult.No;
            {

            };
        }
        #endregion

    }
}
