using System;
using System.IO;
using System.Collections.Generic;


namespace Memberships
{
    class Program
    {
        public class Member
        {
            public int ID { get; set; }
            public string Email { get; set; }
            public double YCost { get; set; }
            public double MPurch { get; set; }
            public string Type { get; set; }
            public Member()
            {
            }
            public Member(int ID, string Email, double YCost, double MPurch, string Type)
            {
                this.ID = ID;
                this.Email = "";
                this.YCost = 0;
                this.MPurch = 0;
                this.Type = "";
            }
        }
        
        
        static void Main(string[] args)
        {          
           List<Member> memList = new List<Member>();
           memList.Add(new Member()
           {
            ID = 1001,
            Email = "TedBundy@yahoo.com",
            YCost = 40,
            MPurch = 349,
            Type = "Regular"
           });
           memList.Add(new Member()
           {
            ID = 1002,
            Email = "NeildeGrassTyson@yahoo.com",
            YCost = 120,
            MPurch = 10754,
            Type = "Executive"
           });
           memList.Add(new Member()
           {
            ID = 1003,
            Email = "Ryan.Reynolds@yahoo.com",
            YCost = 10,
            MPurch = 742,
            Type = "NonProfit"
           });
           memList.Add(new Member()
           {
            ID = 1004,
            Email = "ScarlettJohansson@yahoo.com",
            YCost = 400,
            MPurch = 23456,
            Type = "Corporate"
           });

            string result = "";

            while (result != "Q")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("C: Create a new membership.");
                Console.WriteLine("R: Read all the members.");
                Console.WriteLine("U: Update an existing member.");
                Console.WriteLine("D: Delete an existing member.");
                Console.WriteLine("L: List all types of membership.");
                Console.WriteLine("P: Perform a purchase.");
                Console.WriteLine("T: Perform a return.");
                Console.WriteLine("A: Apply cash-back rewards.");
                Console.WriteLine("Q: Quit this application.");
                string? input = Console.ReadLine();
                result = input.ToUpper();

                switch (result)
                {
                    case "C": 
                        Console.WriteLine("Press A to add a member or any other key to quit.");
                        string? userInput = Console.ReadLine();
                        string choice = userInput.ToUpper();

                        while (choice == "A")
                        {                       
                            int newID;
                            string newEmail;
                            string newType;
                            double newYcost = 0;
                            double newMpurch = 0;

                            Console.Write("Enter the desired member ID number, between 1 and 1000.  ");
                            newID = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the members' Email address: ");
                            newEmail = Console.ReadLine();
                            Console.Write("Enter the preferred membership type: ");
                            newType = Console.ReadLine();
                            memList.Add(new Member(newID, newEmail, newYcost, newMpurch, newType)); 
                            Console.WriteLine("The member has been added with the following details: ");
                            Console.WriteLine("Member ID: " + newID + "\nMember Email: " + newEmail + "\nMember Type: " + newType);
                            Console.WriteLine("Press A to add a member or any other key to quit.");
                            choice = Console.ReadLine();
                                                       
                        }
                        break;
                    case "R":
                        foreach (var member in memList)
                        {
                            Console.WriteLine("Member: ID - {0}, Email - {1}, Yearly Cost - {2}, Current Monthly Purchases - {3}, Member Type - {4}", member.ID, member.Email, member.YCost,member.MPurch, member.Type);
                        }
                        break;
                    case "U":
                        int memID = 0;
                        string eMail = "";
                        double yCost = 0;
                        double mPurch = 0;
                        string type = "";
                        
                        Console.WriteLine("Here are the current members, choose one to update.");
                        foreach (var member in memList)
                        {
                            Console.WriteLine("Member: ID - {0}, Email - {1}, Yearly Cost - {2}, Current Monthly Purchases - {3}, Member Type - {4}", member.ID, member.Email, member.YCost,member.MPurch, member.Type);
                        }
                        Console.WriteLine("Enter the member ID.");
                        memID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new email.");
                        eMail = Console.ReadLine();
                        Console.WriteLine("Enter new member type.");
                        type = Console.ReadLine();

                        var res = from r in memList where r.ID == memID select r;
                        res.First().Email = eMail;
                        res.First().Type = type;
                        break;
                    case "D":                        
                        Console.WriteLine("Here are the current members, choose one to delete.");
                        foreach (var member in memList)
                        {
                            Console.WriteLine("Member: ID - {0}, Email - {1}, Yearly Cost - {2}, Current Monthly Purchases - {3}, Member Type - {4}", member.ID, member.Email, member.YCost,member.MPurch, member.Type);
                        }
                        Console.WriteLine("Enter the member ID.");
                        memID = Convert.ToInt32(Console.ReadLine());

                        res = from r in memList where r.ID == memID select r;
                        memList.Remove(res.First());
                        Console.WriteLine("Member " + memID + " has been removed.");
                        foreach (var member in memList)
                        {
                            Console.WriteLine("Member: ID - {0}, Email - {1}, Yearly Cost - {2}, Current Monthly Purchases - {3}, Member Type - {4}", member.ID, member.Email, member.YCost,member.MPurch, member.Type);
                        }
                        break;
                    case "L":
                        foreach (var member in memList)
                        {
                            Console.WriteLine("Member: ID - {0}, Email - {1}, Yearly Cost - {2}, Current Monthly Purchases - {3}, Member Type - {4}", member.ID, member.Email, member.YCost,member.MPurch, member.Type);
                        }
                        break;
                    case "P":
                        //perform a purchase
                        Regular.Purchase();
                        break;
                    case "T":
                        //perform a return
                        break;
                    case "A":
                        //apply cashback rewards
                        break;
                    case "Q":
                        break;
                }


            }
        }
    }
}