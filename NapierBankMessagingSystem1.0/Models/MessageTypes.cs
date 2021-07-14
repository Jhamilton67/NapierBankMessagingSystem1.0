using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
    public class MessageTypes
    {
        public static string SMS { get; private set; }
        public string MessageHeader { get; set; }
        public string MessageID { get; set; }
        public string Body { get; set; }
        public static string Emails { get; private set; }
        public static string Tweets { get; private set; }
        public static string HashTags { get; private set; }
        public static string Sender { get; private set; }

    }
}
