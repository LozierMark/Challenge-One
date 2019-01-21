using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimRepository
    {
        List<Claim> _claims = new List<Claim>();

        public List<Claim> GetClaims()
        {
            return _claims;
        }
        public void AddClaim(Claim claim)
        {
            _claims.Add(claim);
        }

    }
}
