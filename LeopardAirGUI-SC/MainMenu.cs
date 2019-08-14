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
    public partial class MainMenu : Form
    {
        Membership memberlist = new Membership();
        Flight[] FD = new Flight[6];
        Purchase purchasemenu;
        ViewFlights viewflightmenu;
        ViewSeat viewseatmenu;
        CancelTicket cancelticketmenu;
        ChangeSeat changeseatmenu;
        CheckPoints checkpointsmenu;
        string currentusername;
        StreamWriter Pwriter0, Pwriter1, Pwriter2, Pwriter3, Pwriter4, Pwriter5;
        Passenger searchpass;
        int[] Plistlength = new int[6];
        public MainMenu(Membership Member, string currentuser, Flight FT0, Flight FT1, Flight FT2, Flight FT3, Flight FT4, Flight FT5)
        {
            memberlist = Member;
            FD[0] = FT0;
            FD[1] = FT1;
            FD[2] = FT2;
            FD[3] = FT3;
            FD[4] = FT4;
            FD[5] = FT5;
            currentusername = currentuser;
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            purchasemenu = new Purchase(memberlist, currentusername, FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
            purchasemenu.Show();
        }

        private void btnViewFlight_Click(object sender, EventArgs e)
        {
            viewflightmenu = new ViewFlights(FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
            viewflightmenu.Show();
        }

        private void btnViewSeat_Click(object sender, EventArgs e)
        {
            viewseatmenu = new ViewSeat(FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
            viewseatmenu.Show();
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            cancelticketmenu = new CancelTicket(memberlist, currentusername, FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
            cancelticketmenu.Show();
        }

        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            changeseatmenu = new ChangeSeat(memberlist, currentusername, FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
            changeseatmenu.Show();
        }

        private void btnCheckPoints_Click(object sender, EventArgs e)
        {
            checkpointsmenu = new CheckPoints(memberlist, currentusername);
            checkpointsmenu.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Plistlength[0] = FD[0].PassengerListCount();
            Plistlength[1] = FD[1].PassengerListCount();
            Plistlength[2] = FD[2].PassengerListCount();
            Plistlength[3] = FD[3].PassengerListCount();
            Plistlength[4] = FD[4].PassengerListCount();
            Plistlength[5] = FD[5].PassengerListCount();
            try
            {
                Pwriter0 = new StreamWriter("Passenger0.txt");
                Pwriter1 = new StreamWriter("Passenger1.txt");
                Pwriter2 = new StreamWriter("Passenger2.txt");
                Pwriter3 = new StreamWriter("Passenger3.txt");
                Pwriter4 = new StreamWriter("Passenger4.txt");
                Pwriter5 = new StreamWriter("Passenger5.txt");
                if (Plistlength[0] > 0)
                {
                    for (int i = 0; i < Plistlength[0]; i++)
                    {
                        searchpass = FD[0].AllPassenger(i);
                        Pwriter0.WriteLine(searchpass.Name);
                        Pwriter0.WriteLine(searchpass.ICNumber);
                        Pwriter0.WriteLine(searchpass.PassengSeatRow);
                        Pwriter0.WriteLine(searchpass.PassengSeatColumn);
                    }
                }
                if (Plistlength[1] > 0)
                {
                    for (int j = 0; j < Plistlength[1]; j++)
                    {
                        searchpass = FD[1].AllPassenger(j);
                        Pwriter1.WriteLine(searchpass.Name);
                        Pwriter1.WriteLine(searchpass.ICNumber);
                        Pwriter1.WriteLine(searchpass.PassengSeatRow);
                        Pwriter1.WriteLine(searchpass.PassengSeatColumn);
                    }
                }
                if (Plistlength[2] > 0)
                {
                    for (int k = 0; k < Plistlength[2]; k++)
                    {
                        searchpass = FD[2].AllPassenger(k);
                        Pwriter1.WriteLine(searchpass.Name);
                        Pwriter1.WriteLine(searchpass.ICNumber);
                        Pwriter1.WriteLine(searchpass.PassengSeatRow);
                        Pwriter1.WriteLine(searchpass.PassengSeatColumn);
                    }
                }
                if (Plistlength[3] > 0)
                {
                    for (int l = 0; l < Plistlength[3]; l++)
                    {
                        searchpass = FD[3].AllPassenger(l);
                        Pwriter1.WriteLine(searchpass.Name);
                        Pwriter1.WriteLine(searchpass.ICNumber);
                        Pwriter1.WriteLine(searchpass.PassengSeatRow);
                        Pwriter1.WriteLine(searchpass.PassengSeatColumn);
                    }
                }
                if (Plistlength[4] > 0)
                {
                    for (int m = 0; m < Plistlength[4]; m++)
                    {
                        searchpass = FD[4].AllPassenger(m);
                        Pwriter1.WriteLine(searchpass.Name);
                        Pwriter1.WriteLine(searchpass.ICNumber);
                        Pwriter1.WriteLine(searchpass.PassengSeatRow);
                        Pwriter1.WriteLine(searchpass.PassengSeatColumn);
                    }
                }
                if (Plistlength[5] > 0)
                {
                    for (int n = 0; n < Plistlength[5]; n++)
                    {
                        searchpass = FD[5].AllPassenger(n);
                        Pwriter1.WriteLine(searchpass.Name);
                        Pwriter1.WriteLine(searchpass.ICNumber);
                        Pwriter1.WriteLine(searchpass.PassengSeatRow);
                        Pwriter1.WriteLine(searchpass.PassengSeatColumn);
                    }
                }
                Pwriter0.Close();
                Pwriter1.Close();
                Pwriter2.Close();
                Pwriter3.Close();
                Pwriter4.Close();
                Pwriter5.Close();
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show(nrex.Message + "\n\n\nForce logout.");
            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message + "\n\n\nForce logout.");
            }
            ActiveForm.Close();
        }
    }
}
