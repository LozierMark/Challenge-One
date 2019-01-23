using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class OutingRepository
    {
        List<Outing> _outing = new List<Outing>();

        public void AddItemToOuting(Outing outing)
        {
            return _outings;
        }
        public void Enqueue(Claim claim)
        {
            _claims.Enqueue(claim);
        }
        public void Dequeue()
        {
            _claims.Dequeue();
        }

        public Claim PeekAtClaimQueue()
        {
            return _claims.Peek();
        }

           
    }
}

