﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimRepository
    {
        Queue<Claim> _claims = new Queue<Claim>();

        public Queue<Claim> GetClaims()
        {
            return _claims;
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

