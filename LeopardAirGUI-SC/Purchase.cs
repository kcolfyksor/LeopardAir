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
    public partial class Purchase : Form
    {
        Membership memberlist = new Membership();
        Flight[] FD = new Flight[6];
        Passenger passengerbuy;
        AirTicket Airticket;
        string currentusername;
        string message1;
        double totalprice;
        ViewFlights viewflightsmenu;
        public Purchase(Membership Member, string currentuser, Flight FT0, Flight FT1, Flight FT2, Flight FT3, Flight FT4, Flight FT5)
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
            groupBox3.Enabled = false;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            groupBox2.Enabled = false;
            if (rbnF31.Checked == true)
            {
                SeatInitialise(0);
                groupBox3.Text = FD[0].Code;
            }
            else if (rbnF35.Checked == true)
            {
                SeatInitialise(1);
                groupBox3.Text = FD[1].Code;
            }
            else if (rbnF41.Checked == true)
            {
                SeatInitialise(2);
                groupBox3.Text = FD[2].Code;
            }
            else if (rbnF45.Checked == true)
            {
                SeatInitialise(3);
                groupBox3.Text = FD[3].Code;
            }
            else if (rbnF51.Checked == true)
            {
                SeatInitialise(4);
                groupBox3.Text = FD[4].Code;
            }
            else if (rbnF55.Checked == true)
            {
                SeatInitialise(5);
                groupBox3.Text = FD[5].Code;
            }
            rbnSeat1A.Checked = false;
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            int rowcheck = BuyRow();
            string columncheck = BuyColumn();
            double seatprice = SeatCost();
            if (rowcheck == 0 || columncheck == "G")
            {
                MessageBox.Show("No seat chosen.");
            }
            else
            {
                if (groupBox3.Text == FD[0].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[0].AddPassenger(passengerbuy);
                    FD[0].BuySeating(rowcheck, columncheck);
                    totalprice = FD[0].FlightPrice + seatprice;
                    memberlist.AddPoints(currentusername, totalprice / 2);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[0], rowcheck, columncheck, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[1].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[1].AddPassenger(passengerbuy);
                    FD[1].BuySeating(rowcheck, columncheck);
                    totalprice = FD[1].FlightPrice + seatprice;
                    memberlist.AddPoints(currentusername, totalprice / 2);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[1], rowcheck, columncheck, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[2].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[2].AddPassenger(passengerbuy);
                    FD[2].BuySeating(rowcheck, columncheck);
                    totalprice = FD[2].FlightPrice + seatprice;
                    memberlist.AddPoints(currentusername, totalprice / 2);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[2], rowcheck, columncheck, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[3].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[3].AddPassenger(passengerbuy);
                    FD[3].BuySeating(rowcheck, columncheck);
                    totalprice = FD[3].FlightPrice + seatprice;
                    memberlist.AddPoints(currentusername, totalprice / 2);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[3], rowcheck, columncheck, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[4].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[4].AddPassenger(passengerbuy);
                    FD[4].BuySeating(rowcheck, columncheck);
                    totalprice = FD[4].FlightPrice + seatprice;
                    memberlist.AddPoints(currentusername, totalprice / 2);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[4], rowcheck, columncheck, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[5].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[5].AddPassenger(passengerbuy);
                    FD[5].BuySeating(rowcheck, columncheck);
                    totalprice = FD[5].FlightPrice + seatprice;
                    memberlist.AddPoints(currentusername, totalprice / 2);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[5], rowcheck, columncheck, tbxName1.Text, tbxICNum1.Text);
                }
                ActiveForm.Close();
                Airticket.Show();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int gotrow = RandomRow();
            string gotcolumn = RandomColumn();
            if (rbnF31.Checked == true)
            {
                passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                FD[0].AddPassenger(passengerbuy);
                FD[0].BuySeating(gotrow, gotcolumn);
                totalprice = FD[0].FlightPrice;
                memberlist.AddPoints(currentusername, FD[0].FlightPrice / 2);
                message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                MessageBox.Show(message1);
                Airticket = new AirTicket(FD[0], gotrow, gotcolumn, tbxName1.Text, tbxICNum1.Text);
                ActiveForm.Close();
                Airticket.Show();
            }
            else if (rbnF35.Checked == true)
            {
                passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                FD[1].AddPassenger(passengerbuy);
                FD[1].BuySeating(gotrow, gotcolumn);
                totalprice = FD[1].FlightPrice;
                memberlist.AddPoints(currentusername, FD[1].FlightPrice / 2);
                message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                MessageBox.Show(message1);
                Airticket = new AirTicket(FD[1], gotrow, gotcolumn, tbxName1.Text, tbxICNum1.Text);
                ActiveForm.Close();
                Airticket.Show();
            }
            else if (rbnF41.Checked == true)
            {
                passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                FD[2].AddPassenger(passengerbuy);
                FD[2].BuySeating(gotrow, gotcolumn);
                totalprice = FD[2].FlightPrice;
                memberlist.AddPoints(currentusername, FD[2].FlightPrice / 2);
                message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                MessageBox.Show(message1);
                Airticket = new AirTicket(FD[2], gotrow, gotcolumn, tbxName1.Text, tbxICNum1.Text);
                ActiveForm.Close();
                Airticket.Show();
            }
            else if (rbnF45.Checked == true)
            {
                passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                FD[3].AddPassenger(passengerbuy);
                FD[3].BuySeating(gotrow, gotcolumn);
                totalprice = FD[3].FlightPrice;
                memberlist.AddPoints(currentusername, FD[3].FlightPrice / 2);
                message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                MessageBox.Show(message1);
                Airticket = new AirTicket(FD[3], gotrow, gotcolumn, tbxName1.Text, tbxICNum1.Text);
                ActiveForm.Close();
                Airticket.Show();
            }
            else if (rbnF51.Checked == true)
            {
                passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                FD[4].AddPassenger(passengerbuy);
                FD[4].BuySeating(gotrow, gotcolumn);
                totalprice = FD[4].FlightPrice;
                memberlist.AddPoints(currentusername, FD[4].FlightPrice / 2);
                message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                MessageBox.Show(message1);
                Airticket = new AirTicket(FD[4], gotrow, gotcolumn, tbxName1.Text, tbxICNum1.Text);
                ActiveForm.Close();
                Airticket.Show();
            }
            else if (rbnF55.Checked == true)
            {
                passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                FD[5].AddPassenger(passengerbuy);
                FD[5].BuySeating(gotrow, gotcolumn);
                totalprice = FD[5].FlightPrice;
                memberlist.AddPoints(currentusername, FD[5].FlightPrice / 2);
                message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                MessageBox.Show(message1);
                Airticket = new AirTicket(FD[5], gotrow, gotcolumn, tbxName1.Text, tbxICNum1.Text);
                ActiveForm.Close();
                Airticket.Show();
            }
            else
            { MessageBox.Show("No flight chosen."); }
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            viewflightsmenu = new ViewFlights(FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]);
            viewflightsmenu.Show();
        }
        
        private void btnRedeem_Click(object sender, EventArgs e)
        {
            int redeemrow = BuyRow();
            string redeemcolumn = BuyColumn();
            double minusamt = 9999;

            if (redeemrow == 1 || redeemrow == 2 || redeemrow == 3 || redeemrow == 4 || redeemrow == 5 || redeemrow == 12 || redeemrow == 14)
            {
                minusamt = 1000;
            }
            else if ((redeemrow <= 11 && redeemrow >= 6)||(redeemrow >= 15 && redeemrow <=31))
            {
                minusamt = 400;
            }
            else
            {
                MessageBox.Show("No Seat Chosen.");
            }

            if (memberlist.CurrentPoints(currentusername) >= minusamt)
            {
                if (groupBox3.Text == FD[0].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[0].AddPassenger(passengerbuy);
                    FD[0].BuySeating(redeemrow, redeemcolumn);
                    totalprice = 0;
                    memberlist.DeductPoints(currentusername, minusamt);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[0], redeemrow, redeemcolumn, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[1].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[1].AddPassenger(passengerbuy);
                    FD[1].BuySeating(redeemrow, redeemcolumn);
                    totalprice = 0;
                    memberlist.DeductPoints(currentusername, minusamt);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[1], redeemrow, redeemcolumn, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[2].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[2].AddPassenger(passengerbuy);
                    FD[2].BuySeating(redeemrow, redeemcolumn);
                    totalprice = 0;
                    memberlist.DeductPoints(currentusername, minusamt);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[2], redeemrow, redeemcolumn, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[3].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[3].AddPassenger(passengerbuy);
                    FD[3].BuySeating(redeemrow, redeemcolumn);
                    totalprice = 0;
                    memberlist.DeductPoints(currentusername, minusamt);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[3], redeemrow, redeemcolumn, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[4].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[4].AddPassenger(passengerbuy);
                    FD[4].BuySeating(redeemrow, redeemcolumn);
                    totalprice = 0;
                    memberlist.DeductPoints(currentusername, minusamt);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[4], redeemrow, redeemcolumn, tbxName1.Text, tbxICNum1.Text);
                }
                else if (groupBox3.Text == FD[5].Code)
                {
                    passengerbuy = new Passenger(tbxName1.Text, tbxICNum1.Text);
                    FD[5].AddPassenger(passengerbuy);
                    FD[5].BuySeating(redeemrow, redeemcolumn);
                    totalprice = 0;
                    memberlist.DeductPoints(currentusername, minusamt);
                    message1 = "Air ticket cost:   " + totalprice + "\nCurrent membership points:   " + memberlist.CurrentPoints(currentusername);
                    MessageBox.Show(message1);
                    Airticket = new AirTicket(FD[5], redeemrow, redeemcolumn, tbxName1.Text, tbxICNum1.Text);
                }
                ActiveForm.Close();
                Airticket.Show();
            }
            else
            {
                MessageBox.Show("Insufficient membership points.");
            }
        }

        public void SeatInitialise(int ft)
        {
            if (FD[ft].CheckSeat(1, "A") == true)
                rbnSeat1A.Enabled = false;
            if (FD[ft].CheckSeat(2, "A") == true)
                rbnSeat2A.Enabled = false;
            if (FD[ft].CheckSeat(3, "A") == true)
                rbnSeat3A.Enabled = false;
            if (FD[ft].CheckSeat(4, "A") == true)
                rbnSeat4A.Enabled = false;
            if (FD[ft].CheckSeat(5, "A") == true)
                rbnSeat5A.Enabled = false;
            if (FD[ft].CheckSeat(6, "A") == true)
                rbnSeat6A.Enabled = false;
            if (FD[ft].CheckSeat(7, "A") == true)
                rbnSeat7A.Enabled = false;
            if (FD[ft].CheckSeat(8, "A") == true)
                rbnSeat8A.Enabled = false;
            if (FD[ft].CheckSeat(9, "A") == true)
                rbnSeat9A.Enabled = false;
            if (FD[ft].CheckSeat(10, "A") == true)
                rbnSeat10A.Enabled = false;
            if (FD[ft].CheckSeat(11, "A") == true)
                rbnSeat11A.Enabled = false;
            if (FD[ft].CheckSeat(12, "A") == true)
                rbnSeat12A.Enabled = false;
            if (FD[ft].CheckSeat(14, "A") == true)
                rbnSeat14A.Enabled = false;
            if (FD[ft].CheckSeat(15, "A") == true)
                rbnSeat15A.Enabled = false;
            if (FD[ft].CheckSeat(16, "A") == true)
                rbnSeat16A.Enabled = false;
            if (FD[ft].CheckSeat(17, "A") == true)
                rbnSeat17A.Enabled = false;
            if (FD[ft].CheckSeat(18, "A") == true)
                rbnSeat18A.Enabled = false;
            if (FD[ft].CheckSeat(19, "A") == true)
                rbnSeat19A.Enabled = false;
            if (FD[ft].CheckSeat(20, "A") == true)
                rbnSeat20A.Enabled = false;
            if (FD[ft].CheckSeat(21, "A") == true)
                rbnSeat21A.Enabled = false;
            if (FD[ft].CheckSeat(22, "A") == true)
                rbnSeat22A.Enabled = false;
            if (FD[ft].CheckSeat(23, "A") == true)
                rbnSeat23A.Enabled = false;
            if (FD[ft].CheckSeat(24, "A") == true)
                rbnSeat24A.Enabled = false;
            if (FD[ft].CheckSeat(25, "A") == true)
                rbnSeat25A.Enabled = false;
            if (FD[ft].CheckSeat(26, "A") == true)
                rbnSeat26A.Enabled = false;
            if (FD[ft].CheckSeat(27, "A") == true)
                rbnSeat27A.Enabled = false;
            if (FD[ft].CheckSeat(28, "A") == true)
                rbnSeat28A.Enabled = false;
            if (FD[ft].CheckSeat(29, "A") == true)
                rbnSeat29A.Enabled = false;
            if (FD[ft].CheckSeat(30, "A") == true)
                rbnSeat30A.Enabled = false;
            if (FD[ft].CheckSeat(31, "A") == true)
                rbnSeat31A.Enabled = false;

            if (FD[ft].CheckSeat(1, "B") == true)
                rbnSeat1B.Enabled = false;
            if (FD[ft].CheckSeat(2, "B") == true)
                rbnSeat2B.Enabled = false;
            if (FD[ft].CheckSeat(3, "B") == true)
                rbnSeat3B.Enabled = false;
            if (FD[ft].CheckSeat(4, "B") == true)
                rbnSeat4B.Enabled = false;
            if (FD[ft].CheckSeat(5, "B") == true)
                rbnSeat5B.Enabled = false;
            if (FD[ft].CheckSeat(6, "B") == true)
                rbnSeat6B.Enabled = false;
            if (FD[ft].CheckSeat(7, "B") == true)
                rbnSeat7B.Enabled = false;
            if (FD[ft].CheckSeat(8, "B") == true)
                rbnSeat8B.Enabled = false;
            if (FD[ft].CheckSeat(9, "B") == true)
                rbnSeat9B.Enabled = false;
            if (FD[ft].CheckSeat(10, "B") == true)
                rbnSeat10B.Enabled = false;
            if (FD[ft].CheckSeat(11, "B") == true)
                rbnSeat11B.Enabled = false;
            if (FD[ft].CheckSeat(12, "B") == true)
                rbnSeat12B.Enabled = false;
            if (FD[ft].CheckSeat(14, "B") == true)
                rbnSeat14B.Enabled = false;
            if (FD[ft].CheckSeat(15, "B") == true)
                rbnSeat15B.Enabled = false;
            if (FD[ft].CheckSeat(16, "B") == true)
                rbnSeat16B.Enabled = false;
            if (FD[ft].CheckSeat(17, "B") == true)
                rbnSeat17B.Enabled = false;
            if (FD[ft].CheckSeat(18, "B") == true)
                rbnSeat18B.Enabled = false;
            if (FD[ft].CheckSeat(19, "B") == true)
                rbnSeat19B.Enabled = false;
            if (FD[ft].CheckSeat(20, "B") == true)
                rbnSeat20B.Enabled = false;
            if (FD[ft].CheckSeat(21, "B") == true)
                rbnSeat21B.Enabled = false;
            if (FD[ft].CheckSeat(22, "B") == true)
                rbnSeat22B.Enabled = false;
            if (FD[ft].CheckSeat(23, "B") == true)
                rbnSeat23B.Enabled = false;
            if (FD[ft].CheckSeat(24, "B") == true)
                rbnSeat24B.Enabled = false;
            if (FD[ft].CheckSeat(25, "B") == true)
                rbnSeat25B.Enabled = false;
            if (FD[ft].CheckSeat(26, "B") == true)
                rbnSeat26B.Enabled = false;
            if (FD[ft].CheckSeat(27, "B") == true)
                rbnSeat27B.Enabled = false;
            if (FD[ft].CheckSeat(28, "B") == true)
                rbnSeat28B.Enabled = false;
            if (FD[ft].CheckSeat(29, "B") == true)
                rbnSeat29B.Enabled = false;
            if (FD[ft].CheckSeat(30, "B") == true)
                rbnSeat30B.Enabled = false;
            if (FD[ft].CheckSeat(31, "B") == true)
                rbnSeat31B.Enabled = false;

            if (FD[ft].CheckSeat(1, "C") == true)
                rbnSeat1C.Enabled = false;
            if (FD[ft].CheckSeat(2, "C") == true)
                rbnSeat2C.Enabled = false;
            if (FD[ft].CheckSeat(3, "C") == true)
                rbnSeat3C.Enabled = false;
            if (FD[ft].CheckSeat(4, "C") == true)
                rbnSeat4C.Enabled = false;
            if (FD[ft].CheckSeat(5, "C") == true)
                rbnSeat5C.Enabled = false;
            if (FD[ft].CheckSeat(6, "C") == true)
                rbnSeat6C.Enabled = false;
            if (FD[ft].CheckSeat(7, "C") == true)
                rbnSeat7C.Enabled = false;
            if (FD[ft].CheckSeat(8, "C") == true)
                rbnSeat8C.Enabled = false;
            if (FD[ft].CheckSeat(9, "C") == true)
                rbnSeat9C.Enabled = false;
            if (FD[ft].CheckSeat(10, "C") == true)
                rbnSeat10C.Enabled = false;
            if (FD[ft].CheckSeat(11, "C") == true)
                rbnSeat11C.Enabled = false;
            if (FD[ft].CheckSeat(12, "C") == true)
                rbnSeat12C.Enabled = false;
            if (FD[ft].CheckSeat(14, "C") == true)
                rbnSeat14C.Enabled = false;
            if (FD[ft].CheckSeat(15, "C") == true)
                rbnSeat15C.Enabled = false;
            if (FD[ft].CheckSeat(16, "C") == true)
                rbnSeat16C.Enabled = false;
            if (FD[ft].CheckSeat(17, "C") == true)
                rbnSeat17C.Enabled = false;
            if (FD[ft].CheckSeat(18, "C") == true)
                rbnSeat18C.Enabled = false;
            if (FD[ft].CheckSeat(19, "C") == true)
                rbnSeat19C.Enabled = false;
            if (FD[ft].CheckSeat(20, "C") == true)
                rbnSeat20C.Enabled = false;
            if (FD[ft].CheckSeat(21, "C") == true)
                rbnSeat21C.Enabled = false;
            if (FD[ft].CheckSeat(22, "C") == true)
                rbnSeat22C.Enabled = false;
            if (FD[ft].CheckSeat(23, "C") == true)
                rbnSeat23C.Enabled = false;
            if (FD[ft].CheckSeat(24, "C") == true)
                rbnSeat24C.Enabled = false;
            if (FD[ft].CheckSeat(25, "C") == true)
                rbnSeat25C.Enabled = false;
            if (FD[ft].CheckSeat(26, "C") == true)
                rbnSeat26C.Enabled = false;
            if (FD[ft].CheckSeat(27, "C") == true)
                rbnSeat27C.Enabled = false;
            if (FD[ft].CheckSeat(28, "C") == true)
                rbnSeat28C.Enabled = false;
            if (FD[ft].CheckSeat(29, "C") == true)
                rbnSeat29C.Enabled = false;
            if (FD[ft].CheckSeat(30, "C") == true)
                rbnSeat30C.Enabled = false;
            if (FD[ft].CheckSeat(31, "C") == true)
                rbnSeat31C.Enabled = false;

            if (FD[ft].CheckSeat(1, "D") == true)
                rbnSeat1D.Enabled = false;
            if (FD[ft].CheckSeat(2, "D") == true)
                rbnSeat2D.Enabled = false;
            if (FD[ft].CheckSeat(3, "D") == true)
                rbnSeat3D.Enabled = false;
            if (FD[ft].CheckSeat(4, "D") == true)
                rbnSeat4D.Enabled = false;
            if (FD[ft].CheckSeat(5, "D") == true)
                rbnSeat5D.Enabled = false;
            if (FD[ft].CheckSeat(6, "D") == true)
                rbnSeat6D.Enabled = false;
            if (FD[ft].CheckSeat(7, "D") == true)
                rbnSeat7D.Enabled = false;
            if (FD[ft].CheckSeat(8, "D") == true)
                rbnSeat8D.Enabled = false;
            if (FD[ft].CheckSeat(9, "D") == true)
                rbnSeat9D.Enabled = false;
            if (FD[ft].CheckSeat(10, "D") == true)
                rbnSeat10D.Enabled = false;
            if (FD[ft].CheckSeat(11, "D") == true)
                rbnSeat11D.Enabled = false;
            if (FD[ft].CheckSeat(12, "D") == true)
                rbnSeat12D.Enabled = false;
            if (FD[ft].CheckSeat(14, "D") == true)
                rbnSeat14D.Enabled = false;
            if (FD[ft].CheckSeat(15, "D") == true)
                rbnSeat15D.Enabled = false;
            if (FD[ft].CheckSeat(16, "D") == true)
                rbnSeat16D.Enabled = false;
            if (FD[ft].CheckSeat(17, "D") == true)
                rbnSeat17D.Enabled = false;
            if (FD[ft].CheckSeat(18, "D") == true)
                rbnSeat18D.Enabled = false;
            if (FD[ft].CheckSeat(19, "D") == true)
                rbnSeat19D.Enabled = false;
            if (FD[ft].CheckSeat(20, "D") == true)
                rbnSeat20D.Enabled = false;
            if (FD[ft].CheckSeat(21, "D") == true)
                rbnSeat21D.Enabled = false;
            if (FD[ft].CheckSeat(22, "D") == true)
                rbnSeat22D.Enabled = false;
            if (FD[ft].CheckSeat(23, "D") == true)
                rbnSeat23D.Enabled = false;
            if (FD[ft].CheckSeat(24, "D") == true)
                rbnSeat24D.Enabled = false;
            if (FD[ft].CheckSeat(25, "D") == true)
                rbnSeat25D.Enabled = false;
            if (FD[ft].CheckSeat(26, "D") == true)
                rbnSeat26D.Enabled = false;
            if (FD[ft].CheckSeat(27, "D") == true)
                rbnSeat27D.Enabled = false;
            if (FD[ft].CheckSeat(28, "D") == true)
                rbnSeat28D.Enabled = false;
            if (FD[ft].CheckSeat(29, "D") == true)
                rbnSeat29D.Enabled = false;
            if (FD[ft].CheckSeat(30, "D") == true)
                rbnSeat30D.Enabled = false;
            if (FD[ft].CheckSeat(31, "D") == true)
                rbnSeat31D.Enabled = false;

            if (FD[ft].CheckSeat(1, "E") == true)
                rbnSeat1E.Enabled = false;
            if (FD[ft].CheckSeat(2, "E") == true)
                rbnSeat2E.Enabled = false;
            if (FD[ft].CheckSeat(3, "E") == true)
                rbnSeat3E.Enabled = false;
            if (FD[ft].CheckSeat(4, "E") == true)
                rbnSeat4E.Enabled = false;
            if (FD[ft].CheckSeat(5, "E") == true)
                rbnSeat5E.Enabled = false;
            if (FD[ft].CheckSeat(6, "E") == true)
                rbnSeat6E.Enabled = false;
            if (FD[ft].CheckSeat(7, "E") == true)
                rbnSeat7E.Enabled = false;
            if (FD[ft].CheckSeat(8, "E") == true)
                rbnSeat8E.Enabled = false;
            if (FD[ft].CheckSeat(9, "E") == true)
                rbnSeat9E.Enabled = false;
            if (FD[ft].CheckSeat(10, "E") == true)
                rbnSeat10E.Enabled = false;
            if (FD[ft].CheckSeat(11, "E") == true)
                rbnSeat11E.Enabled = false;
            if (FD[ft].CheckSeat(12, "E") == true)
                rbnSeat12E.Enabled = false;
            if (FD[ft].CheckSeat(14, "E") == true)
                rbnSeat14E.Enabled = false;
            if (FD[ft].CheckSeat(15, "E") == true)
                rbnSeat15E.Enabled = false;
            if (FD[ft].CheckSeat(16, "E") == true)
                rbnSeat16E.Enabled = false;
            if (FD[ft].CheckSeat(17, "E") == true)
                rbnSeat17E.Enabled = false;
            if (FD[ft].CheckSeat(18, "E") == true)
                rbnSeat18E.Enabled = false;
            if (FD[ft].CheckSeat(19, "E") == true)
                rbnSeat19E.Enabled = false;
            if (FD[ft].CheckSeat(20, "E") == true)
                rbnSeat20E.Enabled = false;
            if (FD[ft].CheckSeat(21, "E") == true)
                rbnSeat21E.Enabled = false;
            if (FD[ft].CheckSeat(22, "E") == true)
                rbnSeat22E.Enabled = false;
            if (FD[ft].CheckSeat(23, "E") == true)
                rbnSeat23E.Enabled = false;
            if (FD[ft].CheckSeat(24, "E") == true)
                rbnSeat24E.Enabled = false;
            if (FD[ft].CheckSeat(25, "E") == true)
                rbnSeat25E.Enabled = false;
            if (FD[ft].CheckSeat(26, "E") == true)
                rbnSeat26E.Enabled = false;
            if (FD[ft].CheckSeat(27, "E") == true)
                rbnSeat27E.Enabled = false;
            if (FD[ft].CheckSeat(28, "E") == true)
                rbnSeat28E.Enabled = false;
            if (FD[ft].CheckSeat(29, "E") == true)
                rbnSeat29E.Enabled = false;
            if (FD[ft].CheckSeat(30, "E") == true)
                rbnSeat30E.Enabled = false;
            if (FD[ft].CheckSeat(31, "E") == true)
                rbnSeat31E.Enabled = false;

            if (FD[ft].CheckSeat(1, "F") == true)
                rbnSeat1F.Enabled = false;
            if (FD[ft].CheckSeat(2, "F") == true)
                rbnSeat2F.Enabled = false;
            if (FD[ft].CheckSeat(3, "F") == true)
                rbnSeat3F.Enabled = false;
            if (FD[ft].CheckSeat(4, "F") == true)
                rbnSeat4F.Enabled = false;
            if (FD[ft].CheckSeat(5, "F") == true)
                rbnSeat5F.Enabled = false;
            if (FD[ft].CheckSeat(6, "F") == true)
                rbnSeat6F.Enabled = false;
            if (FD[ft].CheckSeat(7, "F") == true)
                rbnSeat7F.Enabled = false;
            if (FD[ft].CheckSeat(8, "F") == true)
                rbnSeat8F.Enabled = false;
            if (FD[ft].CheckSeat(9, "F") == true)
                rbnSeat9F.Enabled = false;
            if (FD[ft].CheckSeat(10, "F") == true)
                rbnSeat10F.Enabled = false;
            if (FD[ft].CheckSeat(11, "F") == true)
                rbnSeat11F.Enabled = false;
            if (FD[ft].CheckSeat(12, "F") == true)
                rbnSeat12F.Enabled = false;
            if (FD[ft].CheckSeat(14, "F") == true)
                rbnSeat14F.Enabled = false;
            if (FD[ft].CheckSeat(15, "F") == true)
                rbnSeat15F.Enabled = false;
            if (FD[ft].CheckSeat(16, "F") == true)
                rbnSeat16F.Enabled = false;
            if (FD[ft].CheckSeat(17, "F") == true)
                rbnSeat17F.Enabled = false;
            if (FD[ft].CheckSeat(18, "F") == true)
                rbnSeat18F.Enabled = false;
            if (FD[ft].CheckSeat(19, "F") == true)
                rbnSeat19F.Enabled = false;
            if (FD[ft].CheckSeat(20, "F") == true)
                rbnSeat20F.Enabled = false;
            if (FD[ft].CheckSeat(21, "F") == true)
                rbnSeat21F.Enabled = false;
            if (FD[ft].CheckSeat(22, "F") == true)
                rbnSeat22F.Enabled = false;
            if (FD[ft].CheckSeat(23, "F") == true)
                rbnSeat23F.Enabled = false;
            if (FD[ft].CheckSeat(24, "F") == true)
                rbnSeat24F.Enabled = false;
            if (FD[ft].CheckSeat(25, "F") == true)
                rbnSeat25F.Enabled = false;
            if (FD[ft].CheckSeat(26, "F") == true)
                rbnSeat26F.Enabled = false;
            if (FD[ft].CheckSeat(27, "F") == true)
                rbnSeat27F.Enabled = false;
            if (FD[ft].CheckSeat(28, "F") == true)
                rbnSeat28F.Enabled = false;
            if (FD[ft].CheckSeat(29, "F") == true)
                rbnSeat29F.Enabled = false;
            if (FD[ft].CheckSeat(30, "F") == true)
                rbnSeat30F.Enabled = false;
            if (FD[ft].CheckSeat(31, "F") == true)
                rbnSeat31F.Enabled = false;
        }

        public int BuyRow()
        {
            if (rbnSeat1A.Checked == true || rbnSeat1B.Checked == true || rbnSeat1C.Checked == true || rbnSeat1D.Checked == true || rbnSeat1E.Checked == true || rbnSeat1F.Checked == true)
                return 1;
            else if (rbnSeat2A.Checked == true || rbnSeat2B.Checked == true || rbnSeat2C.Checked == true || rbnSeat2D.Checked == true || rbnSeat2E.Checked == true || rbnSeat2F.Checked == true)
                return 2;
            else if (rbnSeat3A.Checked == true || rbnSeat3B.Checked == true || rbnSeat3C.Checked == true || rbnSeat3D.Checked == true || rbnSeat3E.Checked == true || rbnSeat3F.Checked == true)
                return 3;
            else if (rbnSeat4A.Checked == true || rbnSeat4B.Checked == true || rbnSeat4C.Checked == true || rbnSeat4D.Checked == true || rbnSeat4E.Checked == true || rbnSeat4F.Checked == true)
                return 4;
            else if (rbnSeat5A.Checked == true || rbnSeat5B.Checked == true || rbnSeat5C.Checked == true || rbnSeat5D.Checked == true || rbnSeat5E.Checked == true || rbnSeat5F.Checked == true)
                return 5;
            else if (rbnSeat6A.Checked == true || rbnSeat6B.Checked == true || rbnSeat6C.Checked == true || rbnSeat6D.Checked == true || rbnSeat6E.Checked == true || rbnSeat6F.Checked == true)
                return 6;
            else if (rbnSeat7A.Checked == true || rbnSeat7B.Checked == true || rbnSeat7C.Checked == true || rbnSeat7D.Checked == true || rbnSeat7E.Checked == true || rbnSeat7F.Checked == true)
                return 7;
            else if (rbnSeat8A.Checked == true || rbnSeat8B.Checked == true || rbnSeat8C.Checked == true || rbnSeat8D.Checked == true || rbnSeat8E.Checked == true || rbnSeat8F.Checked == true)
                return 8;
            else if (rbnSeat9A.Checked == true || rbnSeat9B.Checked == true || rbnSeat9C.Checked == true || rbnSeat9D.Checked == true || rbnSeat9E.Checked == true || rbnSeat9F.Checked == true)
                return 9;
            else if (rbnSeat10A.Checked == true || rbnSeat10B.Checked == true || rbnSeat10C.Checked == true || rbnSeat10D.Checked == true || rbnSeat10E.Checked == true || rbnSeat10F.Checked == true)
                return 10;
            else if (rbnSeat11A.Checked == true || rbnSeat11B.Checked == true || rbnSeat11C.Checked == true || rbnSeat11D.Checked == true || rbnSeat11E.Checked == true || rbnSeat11F.Checked == true)
                return 11;
            else if (rbnSeat12A.Checked == true || rbnSeat12B.Checked == true || rbnSeat12C.Checked == true || rbnSeat12D.Checked == true || rbnSeat12E.Checked == true || rbnSeat12F.Checked == true)
                return 12;
            else if (rbnSeat14A.Checked == true || rbnSeat14B.Checked == true || rbnSeat14C.Checked == true || rbnSeat14D.Checked == true || rbnSeat14E.Checked == true || rbnSeat14F.Checked == true)
                return 14;
            else if (rbnSeat15A.Checked == true || rbnSeat15B.Checked == true || rbnSeat15C.Checked == true || rbnSeat15D.Checked == true || rbnSeat15E.Checked == true || rbnSeat15F.Checked == true)
                return 15;
            else if (rbnSeat16A.Checked == true || rbnSeat16B.Checked == true || rbnSeat16C.Checked == true || rbnSeat16D.Checked == true || rbnSeat16E.Checked == true || rbnSeat16F.Checked == true)
                return 16;
            else if (rbnSeat17A.Checked == true || rbnSeat17B.Checked == true || rbnSeat17C.Checked == true || rbnSeat17D.Checked == true || rbnSeat17E.Checked == true || rbnSeat17F.Checked == true)
                return 17;
            else if (rbnSeat18A.Checked == true || rbnSeat18B.Checked == true || rbnSeat18C.Checked == true || rbnSeat18D.Checked == true || rbnSeat18E.Checked == true || rbnSeat18F.Checked == true)
                return 18;
            else if (rbnSeat19A.Checked == true || rbnSeat19B.Checked == true || rbnSeat19C.Checked == true || rbnSeat19D.Checked == true || rbnSeat19E.Checked == true || rbnSeat19F.Checked == true)
                return 19;
            else if (rbnSeat20A.Checked == true || rbnSeat20B.Checked == true || rbnSeat20C.Checked == true || rbnSeat20D.Checked == true || rbnSeat20E.Checked == true || rbnSeat20F.Checked == true)
                return 20;
            else if (rbnSeat21A.Checked == true || rbnSeat21B.Checked == true || rbnSeat21C.Checked == true || rbnSeat21D.Checked == true || rbnSeat21E.Checked == true || rbnSeat21F.Checked == true)
                return 21;
            else if (rbnSeat22A.Checked == true || rbnSeat22B.Checked == true || rbnSeat22C.Checked == true || rbnSeat22D.Checked == true || rbnSeat22E.Checked == true || rbnSeat22F.Checked == true)
                return 22;
            else if (rbnSeat23A.Checked == true || rbnSeat23B.Checked == true || rbnSeat23C.Checked == true || rbnSeat23D.Checked == true || rbnSeat23E.Checked == true || rbnSeat23F.Checked == true)
                return 23;
            else if (rbnSeat24A.Checked == true || rbnSeat24B.Checked == true || rbnSeat24C.Checked == true || rbnSeat24D.Checked == true || rbnSeat24E.Checked == true || rbnSeat24F.Checked == true)
                return 24;
            else if (rbnSeat25A.Checked == true || rbnSeat25B.Checked == true || rbnSeat25C.Checked == true || rbnSeat25D.Checked == true || rbnSeat25E.Checked == true || rbnSeat25F.Checked == true)
                return 25;
            else if (rbnSeat26A.Checked == true || rbnSeat26B.Checked == true || rbnSeat26C.Checked == true || rbnSeat26D.Checked == true || rbnSeat26E.Checked == true || rbnSeat26F.Checked == true)
                return 26;
            else if (rbnSeat27A.Checked == true || rbnSeat27B.Checked == true || rbnSeat27C.Checked == true || rbnSeat27D.Checked == true || rbnSeat27E.Checked == true || rbnSeat27F.Checked == true)
                return 27;
            else if (rbnSeat28A.Checked == true || rbnSeat28B.Checked == true || rbnSeat28C.Checked == true || rbnSeat28D.Checked == true || rbnSeat28E.Checked == true || rbnSeat28F.Checked == true)
                return 28;
            else if (rbnSeat29A.Checked == true || rbnSeat29B.Checked == true || rbnSeat29C.Checked == true || rbnSeat29D.Checked == true || rbnSeat29E.Checked == true || rbnSeat29F.Checked == true)
                return 29;
            else if (rbnSeat30A.Checked == true || rbnSeat30B.Checked == true || rbnSeat30C.Checked == true || rbnSeat30D.Checked == true || rbnSeat30E.Checked == true || rbnSeat30F.Checked == true)
                return 30;
            else if (rbnSeat31A.Checked == true || rbnSeat31B.Checked == true || rbnSeat31C.Checked == true || rbnSeat31D.Checked == true || rbnSeat31E.Checked == true || rbnSeat31F.Checked == true)
                return 31;
            else
                return 0;
        }

        public string BuyColumn()
        {
            if (rbnSeat1A.Checked == true || rbnSeat2A.Checked == true || rbnSeat3A.Checked == true || rbnSeat4A.Checked == true || rbnSeat5A.Checked == true || rbnSeat6A.Checked == true || rbnSeat7A.Checked == true || rbnSeat8A.Checked == true || rbnSeat9A.Checked == true || rbnSeat10A.Checked == true ||
                rbnSeat11A.Checked == true || rbnSeat12A.Checked == true || rbnSeat14A.Checked == true || rbnSeat15A.Checked == true || rbnSeat16A.Checked == true || rbnSeat17A.Checked == true || rbnSeat18A.Checked == true || rbnSeat19A.Checked == true || rbnSeat20A.Checked == true ||
                rbnSeat21A.Checked == true || rbnSeat22A.Checked == true || rbnSeat23A.Checked == true || rbnSeat24A.Checked == true || rbnSeat25A.Checked == true || rbnSeat26A.Checked == true || rbnSeat27A.Checked == true || rbnSeat28A.Checked == true || rbnSeat29A.Checked == true || rbnSeat30A.Checked == true ||
                rbnSeat31A.Checked == true)
                return "A";
            else if (rbnSeat1B.Checked == true || rbnSeat2B.Checked == true || rbnSeat3B.Checked == true || rbnSeat4B.Checked == true || rbnSeat5B.Checked == true || rbnSeat6B.Checked == true || rbnSeat7B.Checked == true || rbnSeat8B.Checked == true || rbnSeat9B.Checked == true || rbnSeat10B.Checked == true ||
                rbnSeat11B.Checked == true || rbnSeat12B.Checked == true || rbnSeat14B.Checked == true || rbnSeat15B.Checked == true || rbnSeat16B.Checked == true || rbnSeat17B.Checked == true || rbnSeat18B.Checked == true || rbnSeat19B.Checked == true || rbnSeat20B.Checked == true ||
                rbnSeat21B.Checked == true || rbnSeat22B.Checked == true || rbnSeat23B.Checked == true || rbnSeat24B.Checked == true || rbnSeat25B.Checked == true || rbnSeat26B.Checked == true || rbnSeat27B.Checked == true || rbnSeat28B.Checked == true || rbnSeat29B.Checked == true || rbnSeat30B.Checked == true ||
                rbnSeat31B.Checked == true)
                return "B";

            else if (rbnSeat1C.Checked == true || rbnSeat2C.Checked == true || rbnSeat3C.Checked == true || rbnSeat4C.Checked == true || rbnSeat5C.Checked == true || rbnSeat6C.Checked == true || rbnSeat7C.Checked == true || rbnSeat8C.Checked == true || rbnSeat9C.Checked == true || rbnSeat10C.Checked == true ||
                            rbnSeat11C.Checked == true || rbnSeat12C.Checked == true || rbnSeat14C.Checked == true || rbnSeat15C.Checked == true || rbnSeat16C.Checked == true || rbnSeat17C.Checked == true || rbnSeat18C.Checked == true || rbnSeat19C.Checked == true || rbnSeat20C.Checked == true ||
                            rbnSeat21C.Checked == true || rbnSeat22C.Checked == true || rbnSeat23C.Checked == true || rbnSeat24C.Checked == true || rbnSeat25C.Checked == true || rbnSeat26C.Checked == true || rbnSeat27C.Checked == true || rbnSeat28C.Checked == true || rbnSeat29C.Checked == true || rbnSeat30C.Checked == true ||
                            rbnSeat31C.Checked == true)
                return "C";

            else if (rbnSeat1D.Checked == true || rbnSeat2D.Checked == true || rbnSeat3D.Checked == true || rbnSeat4D.Checked == true || rbnSeat5D.Checked == true || rbnSeat6D.Checked == true || rbnSeat7D.Checked == true || rbnSeat8D.Checked == true || rbnSeat9D.Checked == true || rbnSeat10D.Checked == true ||
                            rbnSeat11D.Checked == true || rbnSeat12D.Checked == true || rbnSeat14D.Checked == true || rbnSeat15D.Checked == true || rbnSeat16D.Checked == true || rbnSeat17D.Checked == true || rbnSeat18D.Checked == true || rbnSeat19D.Checked == true || rbnSeat20D.Checked == true ||
                            rbnSeat21D.Checked == true || rbnSeat22D.Checked == true || rbnSeat23D.Checked == true || rbnSeat24D.Checked == true || rbnSeat25D.Checked == true || rbnSeat26D.Checked == true || rbnSeat27D.Checked == true || rbnSeat28D.Checked == true || rbnSeat29D.Checked == true || rbnSeat30D.Checked == true ||
                            rbnSeat31D.Checked == true)
                return "D";

            else if (rbnSeat1E.Checked == true || rbnSeat2E.Checked == true || rbnSeat3E.Checked == true || rbnSeat4E.Checked == true || rbnSeat5E.Checked == true || rbnSeat6E.Checked == true || rbnSeat7E.Checked == true || rbnSeat8E.Checked == true || rbnSeat9E.Checked == true || rbnSeat10E.Checked == true ||
                            rbnSeat11E.Checked == true || rbnSeat12E.Checked == true || rbnSeat14E.Checked == true || rbnSeat15E.Checked == true || rbnSeat16E.Checked == true || rbnSeat17E.Checked == true || rbnSeat18E.Checked == true || rbnSeat19E.Checked == true || rbnSeat20E.Checked == true ||
                            rbnSeat21E.Checked == true || rbnSeat22E.Checked == true || rbnSeat23E.Checked == true || rbnSeat24E.Checked == true || rbnSeat25E.Checked == true || rbnSeat26E.Checked == true || rbnSeat27E.Checked == true || rbnSeat28E.Checked == true || rbnSeat29E.Checked == true || rbnSeat30E.Checked == true ||
                            rbnSeat31E.Checked == true)
                return "E";

            else if (rbnSeat1F.Checked == true || rbnSeat2F.Checked == true || rbnSeat3F.Checked == true || rbnSeat4F.Checked == true || rbnSeat5F.Checked == true || rbnSeat6F.Checked == true || rbnSeat7F.Checked == true || rbnSeat8F.Checked == true || rbnSeat9F.Checked == true || rbnSeat10F.Checked == true ||
                            rbnSeat11F.Checked == true || rbnSeat12F.Checked == true || rbnSeat14F.Checked == true || rbnSeat15F.Checked == true || rbnSeat16F.Checked == true || rbnSeat17F.Checked == true || rbnSeat18F.Checked == true || rbnSeat19F.Checked == true || rbnSeat20F.Checked == true ||
                            rbnSeat21F.Checked == true || rbnSeat22F.Checked == true || rbnSeat23F.Checked == true || rbnSeat24F.Checked == true || rbnSeat25F.Checked == true || rbnSeat26F.Checked == true || rbnSeat27F.Checked == true || rbnSeat28F.Checked == true || rbnSeat29F.Checked == true || rbnSeat30F.Checked == true ||
                            rbnSeat31F.Checked == true)
                return "F";
            else
                return "G";
        }

        public double SeatCost()
        {
            if (rbnSeat1A.Checked == true || rbnSeat1B.Checked == true || rbnSeat1C.Checked == true || rbnSeat1D.Checked == true || rbnSeat1E.Checked == true || rbnSeat1F.Checked == true)
                return 38;
            else if (rbnSeat2A.Checked == true || rbnSeat2B.Checked == true || rbnSeat2C.Checked == true || rbnSeat2D.Checked == true || rbnSeat2E.Checked == true || rbnSeat2F.Checked == true)
                return 38;
            else if (rbnSeat3A.Checked == true || rbnSeat3B.Checked == true || rbnSeat3C.Checked == true || rbnSeat3D.Checked == true || rbnSeat3E.Checked == true || rbnSeat3F.Checked == true)
                return 38;
            else if (rbnSeat4A.Checked == true || rbnSeat4B.Checked == true || rbnSeat4C.Checked == true || rbnSeat4D.Checked == true || rbnSeat4E.Checked == true || rbnSeat4F.Checked == true)
                return 38;
            else if (rbnSeat5A.Checked == true || rbnSeat5B.Checked == true || rbnSeat5C.Checked == true || rbnSeat5D.Checked == true || rbnSeat5E.Checked == true || rbnSeat5F.Checked == true)
                return 38;
            else if (rbnSeat6A.Checked == true || rbnSeat6B.Checked == true || rbnSeat6C.Checked == true || rbnSeat6D.Checked == true || rbnSeat6E.Checked == true || rbnSeat6F.Checked == true)
                return 18;
            else if (rbnSeat7A.Checked == true || rbnSeat7B.Checked == true || rbnSeat7C.Checked == true || rbnSeat7D.Checked == true || rbnSeat7E.Checked == true || rbnSeat7F.Checked == true)
                return 18;
            else if (rbnSeat8A.Checked == true || rbnSeat8B.Checked == true || rbnSeat8C.Checked == true || rbnSeat8D.Checked == true || rbnSeat8E.Checked == true || rbnSeat8F.Checked == true)
                return 18;
            else if (rbnSeat9A.Checked == true || rbnSeat9B.Checked == true || rbnSeat9C.Checked == true || rbnSeat9D.Checked == true || rbnSeat9E.Checked == true || rbnSeat9F.Checked == true)
                return 18;
            else if (rbnSeat10A.Checked == true || rbnSeat10B.Checked == true || rbnSeat10C.Checked == true || rbnSeat10D.Checked == true || rbnSeat10E.Checked == true || rbnSeat10F.Checked == true)
                return 18;
            else if (rbnSeat11A.Checked == true || rbnSeat11B.Checked == true || rbnSeat11C.Checked == true || rbnSeat11D.Checked == true || rbnSeat11E.Checked == true || rbnSeat11F.Checked == true)
                return 18;
            else if (rbnSeat12A.Checked == true || rbnSeat12B.Checked == true || rbnSeat12C.Checked == true || rbnSeat12D.Checked == true || rbnSeat12E.Checked == true || rbnSeat12F.Checked == true)
                return 38;
            else if (rbnSeat14A.Checked == true || rbnSeat14B.Checked == true || rbnSeat14C.Checked == true || rbnSeat14D.Checked == true || rbnSeat14E.Checked == true || rbnSeat14F.Checked == true)
                return 38;
            else if (rbnSeat15A.Checked == true || rbnSeat15B.Checked == true || rbnSeat15C.Checked == true || rbnSeat15D.Checked == true || rbnSeat15E.Checked == true || rbnSeat15F.Checked == true)
                return 18;
            else if (rbnSeat16A.Checked == true || rbnSeat16B.Checked == true || rbnSeat16C.Checked == true || rbnSeat16D.Checked == true || rbnSeat16E.Checked == true || rbnSeat16F.Checked == true)
                return 18;
            else if (rbnSeat17A.Checked == true || rbnSeat17B.Checked == true || rbnSeat17C.Checked == true || rbnSeat17D.Checked == true || rbnSeat17E.Checked == true || rbnSeat17F.Checked == true)
                return 18;
            else if (rbnSeat18A.Checked == true || rbnSeat18B.Checked == true || rbnSeat18C.Checked == true || rbnSeat18D.Checked == true || rbnSeat18E.Checked == true || rbnSeat18F.Checked == true)
                return 18;
            else if (rbnSeat19A.Checked == true || rbnSeat19B.Checked == true || rbnSeat19C.Checked == true || rbnSeat19D.Checked == true || rbnSeat19E.Checked == true || rbnSeat19F.Checked == true)
                return 18;
            else if (rbnSeat20A.Checked == true || rbnSeat20B.Checked == true || rbnSeat20C.Checked == true || rbnSeat20D.Checked == true || rbnSeat20E.Checked == true || rbnSeat20F.Checked == true)
                return 18;
            else if (rbnSeat21A.Checked == true || rbnSeat21B.Checked == true || rbnSeat21C.Checked == true || rbnSeat21D.Checked == true || rbnSeat21E.Checked == true || rbnSeat21F.Checked == true)
                return 18;
            else if (rbnSeat22A.Checked == true || rbnSeat22B.Checked == true || rbnSeat22C.Checked == true || rbnSeat22D.Checked == true || rbnSeat22E.Checked == true || rbnSeat22F.Checked == true)
                return 18;
            else if (rbnSeat23A.Checked == true || rbnSeat23B.Checked == true || rbnSeat23C.Checked == true || rbnSeat23D.Checked == true || rbnSeat23E.Checked == true || rbnSeat23F.Checked == true)
                return 18;
            else if (rbnSeat24A.Checked == true || rbnSeat24B.Checked == true || rbnSeat24C.Checked == true || rbnSeat24D.Checked == true || rbnSeat24E.Checked == true || rbnSeat24F.Checked == true)
                return 18;
            else if (rbnSeat25A.Checked == true || rbnSeat25B.Checked == true || rbnSeat25C.Checked == true || rbnSeat25D.Checked == true || rbnSeat25E.Checked == true || rbnSeat25F.Checked == true)
                return 18;
            else if (rbnSeat26A.Checked == true || rbnSeat26B.Checked == true || rbnSeat26C.Checked == true || rbnSeat26D.Checked == true || rbnSeat26E.Checked == true || rbnSeat26F.Checked == true)
                return 18;
            else if (rbnSeat27A.Checked == true || rbnSeat27B.Checked == true || rbnSeat27C.Checked == true || rbnSeat27D.Checked == true || rbnSeat27E.Checked == true || rbnSeat27F.Checked == true)
                return 18;
            else if (rbnSeat28A.Checked == true || rbnSeat28B.Checked == true || rbnSeat28C.Checked == true || rbnSeat28D.Checked == true || rbnSeat28E.Checked == true || rbnSeat28F.Checked == true)
                return 18;
            else if (rbnSeat29A.Checked == true || rbnSeat29B.Checked == true || rbnSeat29C.Checked == true || rbnSeat29D.Checked == true || rbnSeat29E.Checked == true || rbnSeat29F.Checked == true)
                return 18;
            else if (rbnSeat30A.Checked == true || rbnSeat30B.Checked == true || rbnSeat30C.Checked == true || rbnSeat30D.Checked == true || rbnSeat30E.Checked == true || rbnSeat30F.Checked == true)
                return 18;
            else if (rbnSeat31A.Checked == true || rbnSeat31B.Checked == true || rbnSeat31C.Checked == true || rbnSeat31D.Checked == true || rbnSeat31E.Checked == true || rbnSeat31F.Checked == true)
                return 18;
            else
                return 0;
        }

        public int RandomRow()
        {
            Random rnd1 = new Random();
            int randrow = 0;
            do
            {
                randrow = rnd1.Next(6, 32);
                if (randrow != 12 && randrow != 13 && randrow != 14)
                { break; }
            } while (randrow == 12 || randrow == 13 || randrow == 14);

            return randrow;
        }

        public string RandomColumn()
        {
            Random rnd2 = new Random();
            int randcolumn = 0;
            string randomcolumn = null;
            do
            {
                randcolumn = rnd2.Next(1, 7);
                if (randcolumn == 1)
                { randomcolumn = "A"; }
                else if (randcolumn == 2)
                { randomcolumn = "B"; }
                else if (randcolumn == 3)
                { randomcolumn = "C"; }
                else if (randcolumn == 4)
                { randomcolumn = "D"; }
                else if (randcolumn == 5)
                { randomcolumn = "E"; }
                else if (randcolumn == 6)
                { randomcolumn = "F"; }
            } while (randcolumn < 1);

            return randomcolumn;
        }
    }
}
