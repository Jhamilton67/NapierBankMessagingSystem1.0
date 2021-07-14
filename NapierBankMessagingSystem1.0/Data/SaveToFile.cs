using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NapierBankMessagingSystem1._0.Data
{
   public  class SaveToFile
   {
        public string SaveDatatoFilePathSMS;
        public string SaveDatatoFilePathEmail;
        public string SaveDatatoFilePathTweets;

        public string ErrorCode { get; set; }

        public SaveToFile()
        {
            SaveDatatoFilePathSMS = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\Napier_Bank_Final\SaveDataFolder\NapierBankSaveDataSMS.txt";
            SaveDatatoFilePathEmail = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\Napier_Bank_Final\SaveDataFolder\NapierBankSaveDataEmail.txt";
            SaveDatatoFilePathTweets = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\Napier_Bank_Final\SaveDataFolder\NapierBankSaveDataTweets.txt)";
            ErrorCode = string.Empty;
        }

        public bool SMSTOFile(SMS mS)
        {
            try
            {
                string FileData = $"{mS.Sender},{mS.Header},{mS.PNumberCode},{mS.MessageText}";
                File.AppendAllText(SaveDatatoFilePathSMS, FileData.ToString());
                FileData = FileData + Environment.NewLine;
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }

        public bool EmailTOFile(Email email)
        {
            try
            {
                string FileData = $"{email.Sender},{email.Subject},{email.MessageText.ToString()},{email.SEM},{email.SIR}";
                File.AppendAllText(SaveDatatoFilePathEmail, FileData.ToString());
                FileData = FileData + Environment.NewLine;
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }

        }

        public bool EmailTOFile(Tweet tweet)
        {
            try
            {
                string FileData = $"{tweet.Sender},{tweet.Hashtag},{tweet.TwitterID},{tweet.Textspeak}";
                File.AppendAllText(SaveDatatoFilePathTweets, FileData.ToString());
                FileData = FileData + Environment.NewLine;
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }


        //private static string[] ReadTweetData(string Sender, string TextSpeak, string Hashtag, string TwitterId)
        //{

        //    string[] DataNotFound = { " Data not Found" };


        //    try
        //    {
        //        string[] data = System.IO.File.ReadAllLines(@Hashtag);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("This is an error ");
        //        return DataNotFound;
        //        throw new ApplicationException("This section of code isnt correct", ex);
        //    }
        //}


   }
}
