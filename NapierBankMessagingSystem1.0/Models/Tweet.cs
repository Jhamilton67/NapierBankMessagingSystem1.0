using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{//I used the data contract so it can use the JSON serialzation to run. 
   [DataContract]
   public  class Tweet
   { //the data members are for the JSOn to recognise that these variables will hold data. 
        [DataMember]
        public string Sender { get; set; }
        [DataMember]
        public string Textspeak { get; set; }
        [DataMember]
        public string Hashtag { get; set; }
        [DataMember]
        public string TwitterID { get; set; }
        [IgnoreDataMember]
        public string TweetIDentify  = "#";

        #region Constructor
        public Tweet()
        {
            Sender = string.Empty;
            Textspeak = string.Empty;
            Hashtag = string.Empty;
            TwitterID = string.Empty;
        }
        #endregion

        #region ToString
        //This will help the code to out put it all in the userInterface
        public override string ToString()
        {
            string TweetData = $"{TwitterID}, {Hashtag}, {Sender} {Textspeak}:" +
                 $"{TwitterID[0]}--{Hashtag[1]}--{Textspeak[2]}--{Sender[3]}";
            return TweetData;
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
        //This get set is used to recognise the # in the tweets.
        //If the program doesnt recognise it will push an error.
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
        #endregion
    }
}
