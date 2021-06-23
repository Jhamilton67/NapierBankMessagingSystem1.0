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
    {
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
        public ObservableCollection<Email> Incidents { get; set; }
        #endregion
        #region Contructor
        public QuarantineListViewModel()
        {
            QDataTextBox = string.Empty;

            ClearQuarantineDataFromTextBoxesButton = "Clear Data";

            ClearQuarantineDataFromTextBoxesButtonCommand = new RelayCommands(ClearQuarantineDataFromTextBoxesButtonClick);

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
        private void ClearQuarantineDataFromTextBoxesButtonClick()
        {
            QDataTextBox = string.Empty;

            OnChnaged(nameof(QDataTextBox));

            MessageBox.Show("Data Cleared");
        }
        #endregion
    }
}
