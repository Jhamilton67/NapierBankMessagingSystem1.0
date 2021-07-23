 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{   
    [DataContract]
    public class Email
    {
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

        public Email()
        {
            Sender = string.Empty;
            Subject = string.Empty;
            MessageText = string.Empty;
            SIR = string.Empty;
            SEM = string.Empty;
        }

        public override string ToString()
        {
            string Emaildata = $"{Sender}, {Subject}, {MessageText}:" +
                $"{Sender[0]}--{Subject[1]}--{MessageText[2]}";
            return Emaildata; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

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


    }

   
}
