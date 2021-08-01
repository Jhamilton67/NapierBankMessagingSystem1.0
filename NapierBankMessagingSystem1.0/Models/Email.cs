 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{//I used the data contract so it can use the JSON serialzation to run. 
    [DataContract]
    public class Email
    {//the data members are for the JSOn to recognise that these variables will hold data. 
        [DataMember]
        public string Sender { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string MessageText { get; set; }

        [DataMember]
        public string EmailIdentify = "@";

        [DataMember]
        public string SIR { get; set; }
        [DataMember]
        public string SEM { get; set; }

        #region Constructor 
        public Email()
        {
            Sender = string.Empty;
            Subject = string.Empty;
            MessageText = string.Empty;
            SIR = string.Empty;
            SEM = string.Empty;
        }
        #endregion

        #region TOstring
        //This will help the code to out put it all in the userInterface
        public override string ToString()
        {
            string Emaildata = $"{Sender}, {Subject}, {MessageText}:" +
                $"{Sender[0]}--{Subject[1]}--{MessageText[2]}";
            return Emaildata; 
        }
        #endregion

         #region HashCode 
        //This hashes all of the data in the class
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

         #region TweetsIdentify
        //This get set is used to recognise the @ in the Emails.
        //If the program doesnt recognise it will push an error.
        public string EmailSymbol
        { 
            get
            {
                return this.EmailSymbol;
            }
            set
            {
                if(value.StartsWith(EmailIdentify))
                {
                    this.EmailIdentify = value;
                }
                else
                {
                    throw new ApplicationException("Emails have to have an @ symbol in them");
                }

            }

        }
        #endregion


    }

   
}
