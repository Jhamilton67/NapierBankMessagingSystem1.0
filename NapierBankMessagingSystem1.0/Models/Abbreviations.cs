using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
    public class Abbreviations
    {
        public string SMSAbrevation { get; set; }
        public string EmailAbrevation{ get; set; }
        public string TweetAbreveation { get; set; }

        private Abbreviations GetAbbreviations = new Abbreviations();
       
        Random random = new Random();

        public int length;

        public Abbreviations()
        {
            string[] messageTypes = { "S", "E", "T" };
        }
        //This will generate 10 digit number for the Abreviations in the Header of each Message
        public string GenerateNumbers()
        {
            var random = new Random();
            string a = string.Empty;
            for(int i = 0; i < length; i++)
            {
                a = string.Concat(a, random.Next(10).ToString());
            }

            return a;
        }

        //Need to test this to see if it will work
        public static string SMSAbreviations(string text, int min, int max )
        {
            string Letter = @"S";
            MatchCollection match = Regex.Matches(text, Letter, RegexOptions.IgnoreCase);

            StringBuilder @string = new StringBuilder();
            foreach (var m in match)
            {
                @string.Append(m + " ");
            }

            Random random = new Random(1111111111);
            int RNumber = random.Next(min, max);

            return @string.ToString().Trim();
           
        }
        



    }
}
