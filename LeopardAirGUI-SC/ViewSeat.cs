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
    public partial class ViewSeat : Form
    {
        Flight[] FD = new Flight[6];
        public ViewSeat(Flight FT0, Flight FT1, Flight FT2, Flight FT3, Flight FT4, Flight FT5)
        {
            FD[0] = FT0;
            FD[1] = FT1;
            FD[2] = FT2;
            FD[3] = FT3;
            FD[4] = FT4;
            FD[5] = FT5;
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string input;
            input = tbxFlightCode.Text;
            if (input.ToUpper() == FD[0].Code)
            {
                groupBox1.Enabled = true;
                SeatInitialise(0);
                groupBox1.Text = FD[0].Code;
                rbnSeat1A.Checked = false;
            }
            else if (input.ToUpper() == FD[1].Code)
            {
                groupBox1.Enabled = true;
                SeatInitialise(1);
                groupBox1.Text = FD[1].Code;
                rbnSeat1A.Checked = false;
            }
            else if (input.ToUpper() == FD[2].Code)
            {
                groupBox1.Enabled = true;
                SeatInitialise(2);
                groupBox1.Text = FD[2].Code;
                rbnSeat1A.Checked = false;
            }
            else if (input.ToUpper() == FD[3].Code)
            {
                groupBox1.Enabled = true;
                SeatInitialise(3);
                groupBox1.Text = FD[3].Code;
                rbnSeat1A.Checked = false;
            }
            else if (input.ToUpper() == FD[4].Code)
            {
                groupBox1.Enabled = true;
                SeatInitialise(4);
                groupBox1.Text = FD[4].Code;
                rbnSeat1A.Checked = false;
            }
            else if (input.ToUpper() == FD[5].Code)
            {
                groupBox1.Enabled = true;
                SeatInitialise(5);
                groupBox1.Text = FD[5].Code;
                rbnSeat1A.Checked = false;
            }
            else
            { MessageBox.Show("Invalid flight code."); }
        }

        private void tbxFlightCode_Click(object sender, EventArgs e)
        {
            rbnSeat1A.Enabled = true;
            rbnSeat2A.Enabled = true;
            rbnSeat3A.Enabled = true;
            rbnSeat4A.Enabled = true;
            rbnSeat5A.Enabled = true;
            rbnSeat6A.Enabled = true;
            rbnSeat7A.Enabled = true;
            rbnSeat8A.Enabled = true;
            rbnSeat9A.Enabled = true;
            rbnSeat10A.Enabled = true;
            rbnSeat11A.Enabled = true;
            rbnSeat12A.Enabled = true;
            rbnSeat14A.Enabled = true;
            rbnSeat15A.Enabled = true;
            rbnSeat16A.Enabled = true;
            rbnSeat17A.Enabled = true;
            rbnSeat18A.Enabled = true;
            rbnSeat19A.Enabled = true;
            rbnSeat20A.Enabled = true;
            rbnSeat21A.Enabled = true;
            rbnSeat22A.Enabled = true;
            rbnSeat23A.Enabled = true;
            rbnSeat24A.Enabled = true;
            rbnSeat25A.Enabled = true;
            rbnSeat26A.Enabled = true;
            rbnSeat27A.Enabled = true;
            rbnSeat28A.Enabled = true;
            rbnSeat29A.Enabled = true;
            rbnSeat30A.Enabled = true;
            rbnSeat31A.Enabled = true;
            
            rbnSeat1B.Enabled = true;
            rbnSeat2B.Enabled = true;
            rbnSeat3B.Enabled = true;
            rbnSeat4B.Enabled = true;
            rbnSeat5B.Enabled = true;
            rbnSeat6B.Enabled = true;
            rbnSeat7B.Enabled = true;
            rbnSeat8B.Enabled = true;
            rbnSeat9B.Enabled = true;
            rbnSeat10B.Enabled = true;
            rbnSeat11B.Enabled = true;
            rbnSeat12B.Enabled = true;
            rbnSeat14B.Enabled = true;
            rbnSeat15B.Enabled = true;
            rbnSeat16B.Enabled = true;
            rbnSeat17B.Enabled = true;
            rbnSeat18B.Enabled = true;
            rbnSeat19B.Enabled = true;
            rbnSeat20B.Enabled = true;
            rbnSeat21B.Enabled = true;
            rbnSeat22B.Enabled = true;
            rbnSeat23B.Enabled = true;
            rbnSeat24B.Enabled = true;
            rbnSeat25B.Enabled = true;
            rbnSeat26B.Enabled = true;
            rbnSeat27B.Enabled = true;
            rbnSeat28B.Enabled = true;
            rbnSeat29B.Enabled = true;
            rbnSeat30B.Enabled = true;
            rbnSeat31B.Enabled = true;
            
            rbnSeat1C.Enabled = true;
            rbnSeat2C.Enabled = true;
            rbnSeat3C.Enabled = true;
            rbnSeat4C.Enabled = true;
            rbnSeat5C.Enabled = true;
            rbnSeat6C.Enabled = true;
            rbnSeat7C.Enabled = true;
            rbnSeat8C.Enabled = true;
            rbnSeat9C.Enabled = true;
            rbnSeat10C.Enabled = true;
            rbnSeat11C.Enabled = true;
            rbnSeat12C.Enabled = true;
            rbnSeat14C.Enabled = true;
            rbnSeat15C.Enabled = true;
            rbnSeat16C.Enabled = true;
            rbnSeat17C.Enabled = true;
            rbnSeat18C.Enabled = true;
            rbnSeat19C.Enabled = true;
            rbnSeat20C.Enabled = true;
            rbnSeat21C.Enabled = true;
            rbnSeat22C.Enabled = true;
            rbnSeat23C.Enabled = true;
            rbnSeat24C.Enabled = true;
            rbnSeat25C.Enabled = true;
            rbnSeat26C.Enabled = true;
            rbnSeat27C.Enabled = true;
            rbnSeat28C.Enabled = true;
            rbnSeat29C.Enabled = true;
            rbnSeat30C.Enabled = true;
            rbnSeat31C.Enabled = true;
            
            rbnSeat1D.Enabled = true;
            rbnSeat2D.Enabled = true;
            rbnSeat3D.Enabled = true;
            rbnSeat4D.Enabled = true;
            rbnSeat5D.Enabled = true;
            rbnSeat6D.Enabled = true;
            rbnSeat7D.Enabled = true;
            rbnSeat8D.Enabled = true;
            rbnSeat9D.Enabled = true;
            rbnSeat10D.Enabled = true;
            rbnSeat11D.Enabled = true;
            rbnSeat12D.Enabled = true;
            rbnSeat14D.Enabled = true;
            rbnSeat15D.Enabled = true;
            rbnSeat16D.Enabled = true;
            rbnSeat17D.Enabled = true;
            rbnSeat18D.Enabled = true;
            rbnSeat19D.Enabled = true;
            rbnSeat20D.Enabled = true;
            rbnSeat21D.Enabled = true;
            rbnSeat22D.Enabled = true;
            rbnSeat23D.Enabled = true;
            rbnSeat24D.Enabled = true;
            rbnSeat25D.Enabled = true;
            rbnSeat26D.Enabled = true;
            rbnSeat27D.Enabled = true;
            rbnSeat28D.Enabled = true;
            rbnSeat29D.Enabled = true;
            rbnSeat30D.Enabled = true;
            rbnSeat31D.Enabled = true;
            
            rbnSeat1E.Enabled = true;
            rbnSeat2E.Enabled = true;
            rbnSeat3E.Enabled = true;
            rbnSeat4E.Enabled = true;
            rbnSeat5E.Enabled = true;
            rbnSeat6E.Enabled = true;
            rbnSeat7E.Enabled = true;
            rbnSeat8E.Enabled = true;
            rbnSeat9E.Enabled = true;
            rbnSeat10E.Enabled = true;
            rbnSeat11E.Enabled = true;
            rbnSeat12E.Enabled = true;
            rbnSeat14E.Enabled = true;
            rbnSeat15E.Enabled = true;
            rbnSeat16E.Enabled = true;
            rbnSeat17E.Enabled = true;
            rbnSeat18E.Enabled = true;
            rbnSeat19E.Enabled = true;
            rbnSeat20E.Enabled = true;
            rbnSeat21E.Enabled = true;
            rbnSeat22E.Enabled = true;
            rbnSeat23E.Enabled = true;
            rbnSeat24E.Enabled = true;
            rbnSeat25E.Enabled = true;
            rbnSeat26E.Enabled = true;
            rbnSeat27E.Enabled = true;
            rbnSeat28E.Enabled = true;
            rbnSeat29E.Enabled = true;
            rbnSeat30E.Enabled = true;
            rbnSeat31E.Enabled = true;
            
            rbnSeat1F.Enabled = true;
            rbnSeat2F.Enabled = true;
            rbnSeat3F.Enabled = true;
            rbnSeat4F.Enabled = true;
            rbnSeat5F.Enabled = true;
            rbnSeat6F.Enabled = true;
            rbnSeat7F.Enabled = true;
            rbnSeat8F.Enabled = true;
            rbnSeat9F.Enabled = true;
            rbnSeat10F.Enabled = true;
            rbnSeat11F.Enabled = true;
            rbnSeat12F.Enabled = true;
            rbnSeat14F.Enabled = true;
            rbnSeat15F.Enabled = true;
            rbnSeat16F.Enabled = true;
            rbnSeat17F.Enabled = true;
            rbnSeat18F.Enabled = true;
            rbnSeat19F.Enabled = true;
            rbnSeat20F.Enabled = true;
            rbnSeat21F.Enabled = true;
            rbnSeat22F.Enabled = true;
            rbnSeat23F.Enabled = true;
            rbnSeat24F.Enabled = true;
            rbnSeat25F.Enabled = true;
            rbnSeat26F.Enabled = true;
            rbnSeat27F.Enabled = true;
            rbnSeat28F.Enabled = true;
            rbnSeat29F.Enabled = true;
            rbnSeat30F.Enabled = true;
            rbnSeat31F.Enabled = true;
            groupBox1.Enabled = false;
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

    }
}
