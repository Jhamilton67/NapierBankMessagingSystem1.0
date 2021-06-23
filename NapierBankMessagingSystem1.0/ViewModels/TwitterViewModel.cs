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
    public class TwitterViewModel : BaseViewModel
    {
        #region TextboxVariables 
        public string TwitterIDTextBox { get; private set; }
        public string HashTagTextBox { get; private set; }
        public string TweetBodyTextBox { get; private set; }
        #endregion
        #region ButtonVariable
        public string ClearTweetDataFromTextBoxesButton { get; private set; }
        #endregion

        #region ICommand 
        public ICommand ClearTweetDataFromTextBoxesButtonCommand { get; private set; }
        #endregion

        public ObservableCollection<Tweet> Tweets { get; set; }
        #region Constructor
        public TwitterViewModel()
        {
            TwitterIDTextBox = string.Empty;
            HashTagTextBox = string.Empty;
            TweetBodyTextBox = string.Empty;

            ClearTweetDataFromTextBoxesButton = "Clear Data";

            ClearTweetDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);

            LoadFromFile load = new LoadFromFile();
            if (!load.DataFromCSVTwitter())
            {
                Tweets = new ObservableCollection<Tweet>();
            }
            else
            {
                Tweets = new ObservableCollection<Tweet>(load.TweetData);
            }
        }
        #endregion
        private void ClearDataFromTextBoxesButtonClick()
        {
            TwitterIDTextBox = string.Empty;
            HashTagTextBox = string.Empty;
            TweetBodyTextBox = string.Empty;

            OnChnaged(nameof(TwitterIDTextBox));
            OnChnaged(nameof(HashTagTextBox));
            OnChnaged(nameof(TweetBodyTextBox));

            MessageBox.Show("Data Cleared");
        }
    }
}
