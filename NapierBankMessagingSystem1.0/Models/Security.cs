using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessagingSystem1._0.Models
{
   public  class Security
   {
        public string SignificantIncidentReports { get; set; }
        public string Subject { get; set; }

        public string SortCode = "99-99-99";

        public string NatureOfIncident { get; set; }

        readonly List<string> Incidents = new List<string>()//List that holds all of the Incidents that
        //could happen to the bank
        {"<-------------------------->",
            "Theft",
            "Staff Attack",
            "ATM Theft",
            "Raid",
            "Customer Attack",
            "Staff Abuse",
            "Bomb Threat",
            "Terrisom",
            "Suspicious Incident",
            "Intelligence",
            "Cash Loss"
        };

    }
}
