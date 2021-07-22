using Microsoft.VisualStudio.TestTools.UnitTesting;
using NapierBankMessagingSystem1._0.Models;
using System;

namespace NapierBankUnitTest
{
    [TestClass]
    public class SmsTest
    {
        SMS GetSms = new SMS();

        [TestMethod]
        public void TestHeader()
        {
            GetSms.Header = "S123452345";
        }
    
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUKPNumber()
        {
            GetSms.PNumberCode = "+441234567524";
        }
        [TestMethod]
        public void TestSMSMessageText()
        {
            GetSms.MessageText = "Hello, This is a test for SMS data";
        }
    }
}
