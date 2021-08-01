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
    {// Getters and setters for the Buttons on the Twitter Page
        #region TextboxVariables 
        public string TwitterIDTextBox { get; private set; }
        public string HashTagTextBox { get; private set; }
        public string TwitterSenderTextBox { get; private set; }
        public string TweetBodyTextBox { get; private set; }
        #endregion
        #region ButtonVariable
        public string ClearTweetDataFromTextBoxesButton { get; private set; }
        public string SaveDataFromtextBoxesButton { get; private set; }
        #endregion

        #region ICommand 
        public ICommand ClearTweetDataFromTextBoxesButtonCommand { get; private set; }
        public ICommand SaveDataFromtextBoxesButtonCommand { get; private set; }
        #endregion
         //Observable collection which holds all the data from the CSV file 
        public ObservableCollection<Tweet> Tweets { get; set; }
        #region Constructor
        public TwitterViewModel()
        {//Clearing the Textboxes to make sure they are always empty when the program loads.
            TwitterIDTextBox = string.Empty;
            HashTagTextBox = string.Empty;
            TweetBodyTextBox = string.Empty;
            TwitterSenderTextBox = string.Empty;
            //The label of each button.

            ClearTweetDataFromTextBoxesButton = "Clear Data";
            SaveDataFromtextBoxesButton = "Save Data";
             //private click helpers linking to Action Method in relayCommands
            ClearTweetDataFromTextBoxesButtonCommand = new RelayCommands(ClearDataFromTextBoxesButtonClick);
            SaveDataFromtextBoxesButtonCommand = new RelayCommands(SaveDataFromtextBoxesButtonClick);

             //Loads in the data from the CSV file in the load class into the constructor 
            //so it runs when the page is opended.
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

        #region Private click helper SaveData
         //Asks the user if they would like to save the data from what they are viewing.
        private void SaveDataFromtextBoxesButtonClick()
        {
            MessageBoxResult message = MessageBox.Show("Do you want to Save the Email data", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (message == MessageBoxResult.Yes)
            {
                //Add in Code for the Save command.

                TweetBodyTextBox = string.Empty;
                TwitterIDTextBox= string.Empty;
                TwitterSenderTextBox = string.Empty;

                OnChnaged(nameof(TweetBodyTextBox));
                OnChnaged(nameof(TwitterIDTextBox));
                OnChnaged(nameof(TwitterSenderTextBox));

               
            }
            else _ = message == MessageBoxResult.No;
            {

            };
        }
        #endregion

        #region Private click helper ClearData
         //Clears all of the data from the textboxes
        private void ClearDataFromTextBoxesButtonClick()
        {
            TwitterIDTextBox = string.Empty;
            HashTagTextBox = string.Empty;
            TwitterSenderTextBox = string.Empty;
            TweetBodyTextBox = string.Empty;

            OnChnaged(nameof(TwitterIDTextBox));
            OnChnaged(nameof(TwitterSenderTextBox));
            OnChnaged(nameof(HashTagTextBox));
            OnChnaged(nameof(TweetBodyTextBox));

            MessageBox.Show("Data Cleared");
        }
    }
}
