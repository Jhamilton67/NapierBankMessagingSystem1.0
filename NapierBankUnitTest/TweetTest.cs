using Microsoft.VisualStudio.TestTools.UnitTesting;
using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NapierBankUnitTest
{
    [TestClass]
    public class TweetTest
    {
        Tweet GetTweet = new Tweet();
        
        [TestMethod]
        public void TestTwitterID()
        {
            GetTweet.TwitterID = "TwitterTestAccount";
        }
        [TestMethod]
        public void TestTwitterHashtag()
        {
            GetTweet.Hashtag = "#TwitterTest";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTwitterIdentify()
        {
            GetTweet.TweetIDentify = "#";
        }
        [TestMethod]
        public void TestTwitterMessage()
        {
            GetTweet.Textspeak = "Hello, This is a test to see if the Twitter data is working";
        }


    }
}
