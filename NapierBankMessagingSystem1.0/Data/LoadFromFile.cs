using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Data
{
    public class LoadFromFile
    {
        private string DataFilePath;
        public string ErrorCode { get; set; }
        #region ListData
        public List<SMS> SMSData { get; set; }
        public List<Tweet> TweetData { get; set; }
        public List<Email> EmailData { get; set; }
        #endregion

        public LoadFromFile()
        {
            DataFilePath = @"C:\Users\user\Desktop\Year 3 of Uni\Software Development\textwords.csv";

            ErrorCode = string.Empty;
            SMSData = new List<SMS>();
            TweetData = new List<Tweet>();
            EmailData = new List<Email>();
        }

        public bool DataFromCSVSMS()
        {
            try
            {
                var info = File.ReadAllLines(DataFilePath);
                foreach(string value in info)
                {
                    var line = value.Split(',');
                    SMSData.Add(new SMS()
                    {
                        Sender = line[0],
                        MessageText = Convert.ToString(line[1])
                    });
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
                var info = File.ReadAllLines(DataFilePath);
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    EmailData.Add(new Email()
                    {
                       Subject = line[0],
                       Sender = Convert.ToString(line[1]),
                       MessageText = Convert.ToString(line[2])
                    });
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
                var info = File.ReadAllLines(DataFilePath);
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    TweetData.Add(new Tweet()
                    {
                        TwitterID = line[0],
                        Hashtag = Convert.ToString(line[1]),
                        Textspeak = Convert.ToString(line[2]),
                        Sender = Convert.ToString(line[3])
                    });
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
