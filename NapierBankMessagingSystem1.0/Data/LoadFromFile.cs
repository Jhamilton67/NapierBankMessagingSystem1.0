using NapierBankMessagingSystem1._0.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Data
{
    public class LoadFromFile
    {   //Loading data Variables 
        private  string DataFilePathForSMS;
        private  string DataFilePathForEmail;
        private  string DataFilePathForTweets;

        public string ErrorCode { get; set; }
        //ListT that are helpinh me to show the data. 
        #region ListData
        public List<SMS> SMSData { get; set; }
        public List<Tweet> TweetData { get; set; }
        public List<Email> EmailData { get; set; }
        #endregion

        #region Constructor 
        //This constructor is used because it is hold all of the File paths which the data will be loaded from  
        //and also it is hold my string for my error code because it should always run first to make sure that
        //The code has no errors in it. 
        //The files paths are text files. 
        public LoadFromFile()
        {
            DataFilePathForSMS = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords1.0.txt";
            DataFilePathForEmail = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords1.0.txt";
            DataFilePathForTweets = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords1.0.txt";

            ErrorCode = string.Empty;
            SMSData = new List<SMS>();//SMS List Data 
            TweetData = new List<Tweet>();//Twitter List Data
            EmailData = new List<Email>();//Email List Data 
        }
        #endregion 
        
        #region DataForSMS
        //This try catch helps me to load all of the 250 data entires, this works also with my JSON 
        //which the client wanted as a requirement. 
        //The data goes through the foreach and is split up so it can be proccessed and then added into the observable collection.
        public bool DataFromCSVSMS()
        {
            try
            {
                SMS mS = new SMS();
                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SMS));
                serializer.WriteObject(stream, mS);

                var info = File.ReadAllLines(DataFilePathForSMS);
                foreach (string value in info)
                {
                    string[] vs = value.Split(',');
                    SMS SmS1Data = new SMS();
                    SMSData.Add(new SMS());
                    {
                        SmS1Data.Header = vs[0];
                        SmS1Data.Sender = vs[1];
                        SmS1Data.MessageText = vs[2];
                    }

                    SMS mS1 = (SMS)serializer.ReadObject(stream);
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }

        }
        #endregion

        
        #region DataForEmail
        public bool DataFromCSVEmail()
        {
            try
            {
                Email email = new Email();
                MemoryStream memory = new MemoryStream();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Email));
                serializer.WriteObject(memory, email);
                var info = File.ReadAllLines(DataFilePathForEmail);
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    EmailData.Add(new Email()
                    {
                       Sender = line[1],
                       Subject = line[2],
                       MessageText = line[3]
                    });
                    Email email1 = (Email)serializer.ReadObject(memory);
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }
        #endregion


        #region Data For Twitter 
        public bool DataFromCSVTwitter()
        {
            try
            {
                Tweet tweets = new Tweet();
                MemoryStream memory = new MemoryStream();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Tweet));
                serializer.WriteObject(memory, tweets);
                var info = File.ReadAllLines(DataFilePathForTweets);
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    TweetData.Add(new Tweet()
                    {
                        TwitterID = line[0],
                        Hashtag = Convert.ToString(line[1]),
                        Textspeak = line[2],
                        Sender = line[3]
                    });
                    Tweet tweet1 = (Tweet)serializer.ReadObject(memory);
                }
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
