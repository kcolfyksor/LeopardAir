using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leopardair_wfa
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
            this.numberofusers = 0;
            this.username = new string[9999];
            this.password = new string[9999];
            this.membershippoints = new double[9999];
        }

        public void Register(string aUsername, string aPassword, double aMPoints)
        {
            this.username[numberofusers] = aUsername;
            this.password[numberofusers] = aPassword;
            this.membershippoints[numberofusers] = aMPoints;
            this.numberofusers++;
        }

        public bool CheckMembership(string bUsername, string bPassword)
        {
            for (int z = 0; z < this.username.Length; z++)
            {
                if (this.username[z] == bUsername)
                {
                    if (this.password[z] == bPassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool SignupMember(string dUsername)
        {
            for (int x = 0; x < this.username.Length; x++)
            {
                if (this.username[x] == dUsername)
                    return true;
            }
            return false;
        }

        public void AddPoints(string cUsername, double cAdditionPoints)
        {
            for (int y = 0; y < this.username.Length; y++)
            {
                if (this.username[y] == cUsername)
                {
                    this.membershippoints[y] += cAdditionPoints;
                }
            }
        }

        public void DeductPoints(string fUsername, double fDeductionPoints)
        {
            for (int y = 0; y < this.username.Length; y++)
            {
                if (this.username[y] == fUsername)
                {
                    this.membershippoints[y] -= fDeductionPoints;
                }
            }
        }

        public double CurrentPoints(string eUsername)
        {
            for (int y = 0; y < this.username.Length; y++)
            {
                if (this.username[y] == eUsername)
                {
                    return this.membershippoints[y];
                }
            }
            return -5;
        }
    }
}
