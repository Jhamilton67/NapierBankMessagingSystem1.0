using Microsoft.VisualStudio.TestTools.UnitTesting;
using NapierBankMessagingSystem1._0.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NapierBankUnitTest
{
    [TestClass]
    public class EmailTest
    {
      Email GetEmail = new Email();
      Security GetSecurity = new Security();
      
      [TestMethod]
      public void TestEmailSender()
      {
            GetEmail.Sender = "EmailTest@testmail23425.co.uk";
      }
      [TestMethod]
      public void TestEmailSubject()
      {
            GetEmail.Subject = "EmailTest";
      }
      [TestMethod]
      public void TestEmailMessageText()
      {
            GetEmail.MessageText = "Hello, This is a test to see if the Email data is working";
      }
      [TestMethod]
      [ExpectedException(typeof(ArgumentException))]
      public void TestEmailIdentify()
      {
            GetEmail.EmailIdentify = "Test@EmailTest.com";
      }
      [TestMethod]
      public void TestIncidintReports()
      {
            GetSecurity.NatureOfIncident = "Cash Loss";
      }
      [TestMethod]
      public void TestSIRList()
      {
            GetEmail.SIR = "Theft";
      }
      [TestMethod]
      public void TestSEMList()
      {
            GetEmail.SEM = " <Quaratined> arwfsdfsfsfsf";
      }
    }
}
