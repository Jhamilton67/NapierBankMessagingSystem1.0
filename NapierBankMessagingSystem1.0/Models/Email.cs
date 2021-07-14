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
            return string.Format("Sender: {1}" + "\n" + "Subject: {2}" + "\n\n" + "MessageText: {3}" + "\n\n", 
                this.Sender, this.Subject, this.MessageText);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

   
}
