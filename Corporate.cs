using System;
using System.IO;
using System.Collections.Generic;


namespace Memberships
{
    class Corporate: Memberships
    {
        private int cbPerc;
        public Corporate() : base()
        {
            cbPerc = 0;
        }

        public Corporate(string newMemId, string newMemEmail, int newYCost, int newMPurch, string newType, int newCBPerc) : base(newMemId, newMemEmail, newYCost, newMPurch, newType)
        {
            cbPerc = newCBPerc;
        }

        public override void CashBack()
        {
            
        }
    }
}