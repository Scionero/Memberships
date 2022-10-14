using System;
using System.IO;
using System.Collections.Generic;

namespace Memberships
{
    class NonProfit: Memberships
    {
        private int cbPerc;
        public NonProfit() : base()
        {
            cbPerc = 0;
            //military or educational
        }

        public NonProfit(string newMemId, string newMemEmail, int newYCost, int newMPurch, string newType, int newCBPerc) : base(newMemId, newMemEmail, newYCost, newMPurch, newType)
        {
            cbPerc = newCBPerc;
        }

        public override void CashBack()
        {
            
        }
    }
}