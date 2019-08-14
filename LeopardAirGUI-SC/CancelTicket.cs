using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leopardair_wfa
{
    public partial class CancelTicket : Form
    {
        Membership memberlist = new Membership();
        Flight[] FD = new Flight[6];
        Passenger foundpassenger;
        string currentusername;
        double minusamt;
        public CancelTicket(Membership Member, string currentuser, Flight FT0, Flight FT1, Flight FT2, Flight FT3, Flight FT4, Flight FT5)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (tbxFlightcode.Text.ToUpper() == FD[0].Code)
            {
                foundpassenger = FD[0].FindPassenger(tbxName.Text, tbxICNumber.Text);
                if (foundpassenger != null)
                {
                    FD[0].CancelSeat(foundpassenger.PassengSeatRow, foundpassenger.PassengSeatColumn);
                    minusamt = FD[0].FlightPrice / 2;
                    memberlist.DeductPoints(currentusername, minusamt);
                    MessageBox.Show("Air ticket cancellation success!\n\nFlight cancellation fee is RM20.");
                }
                else
                {
                    MessageBox.Show("Matching name / IC number not found.\nPlease state name & IC number as shown in air ticket.\n(Case sensitive)");
                }
            }
            else if (tbxFlightcode.Text.ToUpper() == FD[1].Code)
            {
                foundpassenger = FD[1].FindPassenger(tbxName.Text, tbxICNumber.Text);
                if (foundpassenger != null)
                {
                    FD[1].CancelSeat(foundpassenger.PassengSeatRow, foundpassenger.PassengSeatColumn);
                    minusamt = FD[1].FlightPrice / 2;
                    memberlist.DeductPoints(currentusername, minusamt);
                    MessageBox.Show("Air ticket cancellation success!\n\nFlight cancellation fee is RM20.");
                }
                else
                {
                    MessageBox.Show("Matching name / IC number not found.\nPlease state name & IC number as shown in air ticket.\n(Case sensitive)");
                }
            }
            else if (tbxFlightcode.Text.ToUpper() == FD[2].Code)
            {
                foundpassenger = FD[2].FindPassenger(tbxName.Text, tbxICNumber.Text);
                if (foundpassenger != null)
                {
                    FD[2].CancelSeat(foundpassenger.PassengSeatRow, foundpassenger.PassengSeatColumn);
                    minusamt = FD[2].FlightPrice / 2;
                    memberlist.DeductPoints(currentusername, minusamt);
                    MessageBox.Show("Air ticket cancellation success!\n\nFlight cancellation fee is RM20.");
                }
                else
                {
                    MessageBox.Show("Matching name / IC number not found.\nPlease state name & IC number as shown in air ticket.\n(Case sensitive)");
                }
            }
            else if (tbxFlightcode.Text.ToUpper() == FD[3].Code)
            {
                foundpassenger = FD[3].FindPassenger(tbxName.Text, tbxICNumber.Text);
                if (foundpassenger != null)
                {
                    FD[3].CancelSeat(foundpassenger.PassengSeatRow, foundpassenger.PassengSeatColumn);
                    minusamt = FD[3].FlightPrice / 2;
                    memberlist.DeductPoints(currentusername, minusamt);
                    MessageBox.Show("Air ticket cancellation success!\n\nFlight cancellation fee is RM20.");
                }
                else
                {
                    MessageBox.Show("Matching name / IC number not found.\nPlease state name & IC number as shown in air ticket.\n(Case sensitive)");
                }
            }
            else if (tbxFlightcode.Text.ToUpper() == FD[4].Code)
            {
                foundpassenger = FD[4].FindPassenger(tbxName.Text, tbxICNumber.Text);
                if (foundpassenger != null)
                {
                    FD[4].CancelSeat(foundpassenger.PassengSeatRow, foundpassenger.PassengSeatColumn);
                    minusamt = FD[4].FlightPrice / 2;
                    memberlist.DeductPoints(currentusername, minusamt);
                    MessageBox.Show("Air ticket cancellation success!\n\nFlight cancellation fee is RM20.");
                }
                else
                {
                    MessageBox.Show("Matching name / IC number not found.\nPlease state name & IC number as shown in air ticket.\n(Case sensitive)");
                }
            }
            else if (tbxFlightcode.Text.ToUpper() == FD[5].Code)
            {
                foundpassenger = FD[5].FindPassenger(tbxName.Text, tbxICNumber.Text);
                if (foundpassenger != null)
                {
                    FD[5].CancelSeat(foundpassenger.PassengSeatRow, foundpassenger.PassengSeatColumn);
                    minusamt = FD[5].FlightPrice / 2;
                    memberlist.DeductPoints(currentusername, minusamt);
                    MessageBox.Show("Air ticket cancellation success!\n\nFlight cancellation fee is RM20.");
                }
                else
                {
                    MessageBox.Show("Matching name / IC number not found.\nPlease state name & IC number as shown in air ticket.\n(Case sensitive)");
                }
            }
            else
            {
                MessageBox.Show("Invalid flight code.");
            }
        }
    }

}
