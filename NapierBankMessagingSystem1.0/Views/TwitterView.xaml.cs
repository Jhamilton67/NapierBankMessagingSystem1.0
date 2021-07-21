using NapierBankMessagingSystem1._0.Models;
using NapierBankMessagingSystem1._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NapierBankMessagingSystem1._0.Views
{
    /// <summary>
    /// Interaction logic for TwitterView.xaml
    /// </summary>
    public partial class TwitterView : UserControl
    {
        public TwitterView()
        {
            InitializeComponent();

            this.DataContext = new TwitterViewModel();
        }

        private void TweetComboBoxData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tweet TweetData1 = TweetComboBoxData.SelectedItem as Tweet;
            MessageBoxTweetBody.Text = TweetData1.Textspeak;
            MessageBoxTweetID.Text = TweetData1.TwitterID;
            MessageBoxTweetHashtag.Text = TweetData1.TweetsHashtag;
            MessageBoxTweetSender.Text = TweetData1.Sender;

            MessageBox.Show(TweetComboBoxData.SelectedItem.ToString());
            TweetData1.ToString();
            
        }
    }
}
