using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class Outing
    {
        public string EventType { get; set; }
        public int NumberPeople  { get; set; }
        public DateTime OutingDate  { get; set; }
        public decimal OutingCPP { get; set; }
        public decimal CostPerEvent { get; set; }
        
        public Outing(string eventType, int numberPeople,DateTime OutingDate, decimal)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            IncidentDate = incidentDate;
            ClaimDate = claimDate;
            ValidClaim = validClaim;
        }

        public Claim()
        {
        }
    }
}
