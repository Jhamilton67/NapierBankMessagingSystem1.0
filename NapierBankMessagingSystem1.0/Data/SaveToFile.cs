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
   { //Saving Data Variables 
        public string SaveDatatoFilePathSMS;
        public string SaveDatatoFilePathEmail;
        public string SaveDatatoFilePathTweets;

        public string ErrorCode { get; set; }//This string is used to help me with error handling inside the code. 
        //It is more of a back end function instead of a client function.
        #region Constructor
        //This constructor is used because it is hold all of the File paths which the data will be saved too 
        //and also it is hold my string for my error code because it should always run first to make sure that
        //The code has no errors in it. 
        public SaveToFile()
        {
            SaveDatatoFilePathSMS = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\Napier_Bank_Final\SaveDataFolder\NapierBankSaveDataSMS.txt";
            SaveDatatoFilePathEmail = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\Napier_Bank_Final\SaveDataFolder\NapierBankSaveDataEmail.txt";
            SaveDatatoFilePathTweets = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\Napier_Bank_Final\SaveDataFolder\NapierBankSaveDataTweets.txt)";
            ErrorCode = string.Empty;
        }
        #endregion

        #region SMSSaveTOFile
        //This try catch will hold all of the information that will be processed and sent to the files.
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
        #endregion

        #region EmailSaveToFile
        //This try catch will hold all of the information that will be processed and sent to the files.
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
        #endregion

        #region TwitterSaveToFile
        //This try catch will hold all of the information that will be processed and sent to the files.
        public bool TwitterTOFile(Tweet tweet)
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
        #endregion

   }
}
