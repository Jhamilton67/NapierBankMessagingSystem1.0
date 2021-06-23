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

       // List<Email> Incidents = new List<Email>();
       
        public string SortCode = "99-99-99";

        public string NatureOfIncident { get; set; }

        List<string> Incidents = new List<string>()
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
