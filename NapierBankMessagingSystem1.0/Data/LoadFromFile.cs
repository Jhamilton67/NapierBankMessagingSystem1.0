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
    {   //This will have to be checked to see if i can use each file for differnt data. 
        private  string DataFilePathForSMS;
        private  string DataFilePathForEmail;
        private  string DataFilePathForTweets;

        public string ErrorCode { get; set; }

        #region ListData
        public List<SMS> SMSData { get; set; }
        public List<Tweet> TweetData { get; set; }
        public List<Email> EmailData { get; set; }
        #endregion

        public LoadFromFile()
        {
            DataFilePathForSMS = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords1.0.txt";
            DataFilePathForEmail = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords1.0.txt";
            DataFilePathForTweets = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords1.0.txt";


            ErrorCode = string.Empty;
            SMSData = new List<SMS>();
            TweetData = new List<Tweet>();
            EmailData = new List<Email>();
        }

        //public bool NewDataSMSFromCSV()
        //{
        //    try
        //    {
        //        var info = File.ReadAllLines(DataFilePathForSMS, Encoding.Unicode);
        //        foreach (string value in info)
        //        {
        //            var line = value.Split(',');
        //            SMSData.Add(new SMS()
        //            {
        //                Sender = line[0],
        //                MessageText = line[1]

        //            });
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorCode = ex.ToString();
        //        return false;
        //    }
        //}


        public bool DataFromCSVSMS()
        {
            try
            {
                //SMS mS = new SMS();
                //MemoryStream stream = new MemoryStream();
                //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SMS));
                //serializer.WriteObject(stream, mS);
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
                 
                    //SMS mS1 = (SMS)serializer.ReadObject(stream);
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }

           
        }

        public bool DataFromCSVEmail()
        {
            try
            {
                //Email email = new Email();
                //MemoryStream memory = new MemoryStream();
                //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Email));
                //serializer.WriteObject(memory, email);
                var info = File.ReadAllLines(DataFilePathForEmail);
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    EmailData.Add(new Email()
                    {
                       Sender = line[1],
                       MessageText = line[2],

                       SIR = line[3],
                       SEM = line[4]
                    });
                //    Email email1 = (Email)serializer.ReadObject(memory);
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }

        public bool DataFromCSVTwitter()
        {
            try
            {
                //Tweet tweets = new Tweet();
                //MemoryStream memory = new MemoryStream();
                //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Tweet));
                //serializer.WriteObject(memory, tweets);
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
                //    Tweet tweet1 = (Tweet)serializer.ReadObject(memory);
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }
    }
}
