using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
    [DataContract]
   public  class Tweet
   {    [DataMember]
        public string Sender { get; set; }
        [DataMember]
        public string Textspeak { get; set; }
        [DataMember]
        public string Hashtag { get; set; }
        [DataMember]
        public string TwitterID { get; set; }
        [IgnoreDataMember]
        public string TweetIDentify  = "#";

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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string TweetsHashtag
        {

            get
            {
                return this.TweetsHashtag;
            }
            set
            {
                if (value.StartsWith(TweetIDentify))
                {
                    this.TweetIDentify = value;
                }
                else
                {
                    throw new ApplicationException("This has to start with a # for a Tweet");
                }

            }

        }
    }
}
