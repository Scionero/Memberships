using System;
using System.IO;
using System.Collections.Generic;


namespace Memberships
{
    class Regular: Memberships, ISpecOfs
    {
        private int cbPerc;
        public Regular() : base()
        {
            cbPerc = 0;
        }

        public Regular(string newMemId, string newMemEmail, double newYCost, double newMPurch, string newType, int newCBPerc) : base(newMemId, newMemEmail, newYCost, newMPurch, newType)
        {
            cbPerc = newCBPerc;
        }

        public double offer()
        {
            return YCost = YCost * .75;      
        }

        public override void CashBack()
        {
            
        }
    }
}