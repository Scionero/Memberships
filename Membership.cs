using System;
using System.IO;
using System.Collections.Generic;

namespace Memberships
{
    abstract class Memberships
    {
        private string memId;
        private string memEmail;
        private double yCost;
        private double mPurch;
        private string type;

        public Memberships()
        {
            memId = "";
            memEmail = "";
            yCost = 0;
            mPurch = 0;
            type = "";
        }
        
        public Memberships(string newMemId, string newMemEmail, double newYCost, double newMPurch, string newType)
        {
            memId = newMemId;
            memEmail = newMemEmail;
            yCost = newYCost;
            mPurch = newMPurch;
            type = newType;
        }

        public string MemID
        {
            get { return memId; }
            set { memId = value; }
        }
        public string MemEmail
        {
            get { return memEmail; }
            set { memEmail = value; }
        }
        public double YCost
        {
            get { return yCost; }
            set { yCost = value; }
        }
        public double MPurch
        {
            get { return mPurch; }
            set { mPurch = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public static void Purchase()
        {
            // double purchase;
            // double result;
            // Console.WriteLine("What is the total amount for todays purchase?");
            // purchase = Convert.ToDouble(Console.ReadLine());
            // result = mPurch + purchase;
        }

        public void Return()
        {

        }

        public abstract void CashBack();

        public override string ToString()
        {
            return ("Membership ID: " + this.memId + "\nContact Email: " + this.memEmail + "\nAnnual Cost: " + this.yCost + "\nCurrent Monthly Purchases: " + this.yCost + "\nMembership Type: " + this.type);
        }
    }
}