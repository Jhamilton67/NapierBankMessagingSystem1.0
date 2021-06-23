using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
   public  class Tweet
   {
        public string Sender { get; set; }
        public string Textspeak { get; set; }
        public string Hashtag { get; set; }
        public string TwitterID { get; set; }

        public Tweet()
        {
            Sender = string.Empty;
            Textspeak = string.Empty;
            Hashtag = string.Empty;
            TwitterID = string.Empty;
        }

        public override string ToString()
        {
            return base.ToString();
        }
   }
}
