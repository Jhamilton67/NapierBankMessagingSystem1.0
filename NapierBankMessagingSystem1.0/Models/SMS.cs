using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
    public class SMS
    {
        public string Header { get; set; }
        public string Sender { get; set; }
        public string MessageText { get; set; }

        public SMS()
        {
            Header = string.Empty;
            Sender = string.Empty;
            MessageText = string.Empty; 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
