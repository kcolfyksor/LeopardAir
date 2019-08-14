using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeopardAirr
{
    public class Membership
    {
        private string[] username;
        public string[] Username
        {
            get { return username; }
        }

        private string[] password;
        public string[] Password
        { get { return password; } }

        private int numberofusers;
        public int NumberOfUsers
        { get { return numberofusers; } }

        private double[] membershippoints;
        public double[] MembershipPoints
        { get { return membershippoints; } }

        public Membership()
        {
            numberofusers = 0;
            username = new string[9999];
            password = new string[9999];
            membershippoints = new double[9999];
        }

        public void Register(string aUsername, string aPassword)
        {
            username[numberofusers] = aUsername;
            password[numberofusers] = aPassword;
            membershippoints[numberofusers] = 0;
            numberofusers++;
        }

        public bool CheckMembership(string bUsername, string bPassword)
        {
            for (int z = 0; z < username.Length; z++)
            {
                if (username[z] == bUsername)
                {
                    if(password[z] == bPassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool SignupMember(string dUsername)
        {
            for (int x = 0; x < username.Length; x++)
            {
                if (username[x] == dUsername)
                    return true;
            }
            return false;
        }

        public void AddPoints(string cUsername, double aAdditionPoints)
        {
            for (int y = 0; y < username.Length; y++)
            {
                if (username[y] == cUsername)
                {
                    membershippoints[y] += aAdditionPoints;
                }
            }
        }

        public void DeductPoints(string gUsername, double gDeductionPoints)
        {
            for (int y = 0; y < username.Length; y++)
            {
                if (username[y] == gUsername)
                {
                    membershippoints[y] -= gDeductionPoints;
                }
            }
        }

        public double CurrentPoints(string eUsername)
        {
            for (int y = 0; y < username.Length; y++)
            {
                if (username[y] == eUsername)
                {
                    return membershippoints[y];
                }
            }
            return -5;
        }

        public void PrintPoints(string PPUsername, double PPPoints)
        {
            Console.WriteLine("...............................................................................................................................");
            Console.WriteLine("..  |||         ||||||||||   ||||||||   |||||||||    ||||||||   |||||||||   |||||||||    ||||||||   ||||||||||  |||||||||    ..");
            Console.WriteLine("..  |||         ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||   ..");
            Console.WriteLine("..  |||         |||         |||    |||  |||    |||  |||    |||  |||    |||  |||    |||  |||    |||     ||||     |||    |||   ..");
            Console.WriteLine("..  |||         ||||||||||  |||    |||  ||||||||||  ||||||||||  ||||||||||  |||    |||  ||||||||||     ||||     ||||||||||   ..");
            Console.WriteLine("..  |||         ||||||||||  |||    |||  |||||||||   ||||||||||  |||||||||   |||    |||  ||||||||||     ||||     |||||||||    ..");
            Console.WriteLine("..  |||         |||         |||    |||  |||         |||    |||  ||| |||     |||    |||  |||    |||     ||||     ||| ||||     ..");
            Console.WriteLine("..  ||||||||||  ||||||||||  ||||||||||  |||         |||    |||  |||   |||   ||||||||||  |||    |||  ||||||||||  |||   |||    ..");
            Console.WriteLine("..  ||||||||||  ||||||||||   ||||||||   |||         |||    |||  |||     ||| |||||||||   |||    |||  ||||||||||  |||     |||  ..");
            Console.WriteLine("...............................................................................................................................");
            Console.WriteLine();
            Console.WriteLine("\t\t\t MEMBER PROFILE");
            Console.WriteLine();
            Console.WriteLine("\tUsername:                  {0}", PPUsername);
            Console.WriteLine();
            Console.WriteLine("\tCurrent Points:            {0}", PPPoints);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
