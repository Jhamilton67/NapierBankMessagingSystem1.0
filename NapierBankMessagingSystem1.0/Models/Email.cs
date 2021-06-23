using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
    public class Email
    {
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }

        public string SIR { get; set; }
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
            return base.ToString();
        }

    }

   
}
