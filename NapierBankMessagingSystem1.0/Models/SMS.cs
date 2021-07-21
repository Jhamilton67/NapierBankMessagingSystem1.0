using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
    [DataContract]
    public class SMS
    {
        [DataMember]
        public string Header { get; set; }
        [DataMember]
        public string Sender { get; set; }
        [DataMember]
        public string MessageText { get; set; }
        [DataMember]
        public string UkNumberCode = "+"; 
        #region Regex
        public static string SMSdata { get; private set; }
        #endregion
        public SMS()
        {
            Header = string.Empty;
            Sender = string.Empty;
            MessageText = string.Empty;
        }
        //Need to test the code 
        public override string ToString()
        {
            string data = $"{Header} {Sender} {MessageText}: " +
                $"{Header[0]}--{Sender[1]}--{MessageText[2]}";
            return data;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string PNumberCode
        {
            
            get
            {
                return this.PNumberCode;
            }
            set
            {
                if (value.StartsWith(UkNumberCode))
                {
                    this.UkNumberCode = value;
                }
                else
                {
                    throw new Exception("This code doesnt start with +");
                }

            }

        }

        //This needs to be Tested to make sure the Code Actually works
        //public static bool GetSMS()
        //{
        //    CheckSmS();
        //    Replace();
        //    return Regex.Match(SMSdata, @"^(\+[1-9][0-9]*(\([0-9]*\)|-[0-9]*-))?[0]?[1-9][0-9\- ]*$").Success;
        //}

        //private static string CheckSmS()
        //{
        //    string input = "Laugh Out Loud";
        //    string Pattern = @"?<MessageText>^(\+[1-9][0-9]*(\([0-9]*\)|-[0-9]*-))?[0]?[1-9][0-9\- ]*$";
        //    Match match = Regex.Match(input, Pattern);
        //    return match.Groups["MessageText"].Value;
        //}

        //private static string Replace()
        //{
        //    string input = "Laugh out Loud";
        //    string pattern = @"?<MessageText>^(\+[1-9][0-9]*(\([0-9]*\)|-[0-9]*-))?[0]?[1-9][0-9\- ]*$";

        //    return Regex.Replace(input, pattern, "Sms");
        //}

    }
}
