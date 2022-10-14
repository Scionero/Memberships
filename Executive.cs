using System;
using System.IO;
using System.Collections.Generic;


namespace Memberships
{
    class Executive: Memberships, ISpecOfs
    {
        private int cbPerc;
        public Executive() : base()
        {
            cbPerc = 0;
        }

        public Executive(string newMemId, string newMemEmail, double newYCost, double newMPurch, string newType, int newCBPerc) : base(newMemId, newMemEmail, newYCost, newMPurch, newType)
        {
            cbPerc = newCBPerc;
        }

        public double offer()
        {
            return YCost = YCost *.5;
        }

        public override void CashBack()
        {
            
        }
    }
}