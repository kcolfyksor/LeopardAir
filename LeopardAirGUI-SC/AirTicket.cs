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
    public partial class AirTicket : Form
    {
        public AirTicket(Flight FT, int passRow, string passColumn, string passName, string passICNum)
        {
            InitializeComponent();
            lblPassName2.Text = passName;
            lblPassICNum2.Text = passICNum;
            lblPassFlightC2.Text = FT.Code;
            lblPassSeatR2.Text = Convert.ToString(passRow);
            lblPassSeatC2.Text = passColumn;
            lblPassDesti2.Text = FT.ArrivalCity;
            lblPassDepartDate2.Text = FT.Date;
            lblPassDepartTime2.Text = FT.DepartureTime;
        }
    }
}
