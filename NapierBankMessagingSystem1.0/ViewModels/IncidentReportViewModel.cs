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
        {
            ClearDatafromTextBoxesButton = "Clear Data";

            TextboxSIRList = string.Empty;
            TextBoxMentions = string.Empty;
    
            ClearDatafromTextBoxesButtonCommand = new RelayCommands(ClearDatafromTextBoxesButtonClick);
           
        }
        #endregion

        #region Private Click Helpers
        private void ClearDatafromTextBoxesButtonClick()
        {
            TextBoxMentions = string.Empty;
            TextBoxMentions = string.Empty;

            OnChnaged(nameof(TextBoxMentions));
            OnChnaged(nameof(TextboxSIRList));

            MessageBox.Show("Data Cleared");
        }
        #endregion

    }
}
