using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace leopardair_wfa
{
    public partial class LoginMenu : Form
    {
        Membership memberlist = new Membership();
        Flight[] FD = new Flight[6];
        MainMenu mainmenu;
        StreamWriter register;
        public LoginMenu(Membership Member, Flight FT0, Flight FT1, Flight FT2, Flight FT3, Flight FT4, Flight FT5)
        {
            memberlist = Member;
            FD[0] = FT0;
            FD[1] = FT1;
            FD[2] = FT2;
            FD[3] = FT3;
            FD[4] = FT4;
            FD[5] = FT5;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool existusername;
            
            existusername = memberlist.CheckMembership(tbxUsername.Text, tbxPassword.Text);
            if(existusername == false)
            {
                MessageBox.Show("Invalid username/password.");
            }
            else
            {
                try
                {
                    string currentuser = tbxUsername.Text;
                    mainmenu = new MainMenu(memberlist, currentuser, FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
                    mainmenu.Show();
                }
                catch
                {
                    MessageBox.Show("Fail to run.");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool usedusername;

            if (tbxUsername.Text == "" || tbxUsername.Text == " " || tbxUsername.Text == null)
            {
                MessageBox.Show("Invalid username.");
            }
            else
            {
                usedusername = memberlist.SignupMember(tbxUsername.Text);
                if (usedusername == true)
                {
                    MessageBox.Show("This username is taken.");
                }
                else
                {
                    memberlist.Register(tbxUsername.Text, tbxPassword.Text, 0);
                    register = new StreamWriter("Membership.txt", true);
                    register.WriteLine(tbxUsername.Text);
                    register.WriteLine(tbxPassword.Text);
                    register.Close();
                    MessageBox.Show("Registration successful.");
                }
            }
        }
    }
}
