using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimDescription { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime IncidentDate { get; set; }
        public DateTime ClaimDate { get; set; }
        public bool ValidClaim { get; set; }

        public Claim(int claimID, string claimType, string claimDescription, double claimAmount, DateTime incidentDate, DateTime claimDate, bool validClaim)
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
