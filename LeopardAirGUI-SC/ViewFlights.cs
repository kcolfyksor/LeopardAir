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
    public partial class ViewFlights : Form
    {
        public ViewFlights(Flight FT0, Flight FT1, Flight FT2, Flight FT3, Flight FT4, Flight FT5)
        {
            InitializeComponent();
            lblFCode1.Text = FT0.Code;
            lblFCode2.Text = FT1.Code;
            lblFCode3.Text = FT2.Code;
            lblFCode4.Text = FT3.Code;
            lblFCode5.Text = FT4.Code;
            lblFCode6.Text = FT5.Code;
            lblDestine1.Text = FT0.ArrivalCity;
            lblDestine2.Text = FT1.ArrivalCity;
            lblDestine3.Text = FT2.ArrivalCity;
            lblDestine4.Text = FT3.ArrivalCity;
            lblDestine5.Text = FT4.ArrivalCity;
            lblDestine6.Text = FT5.ArrivalCity;
            lblDate1.Text = FT0.Date;
            lblDate2.Text = FT1.Date;
            lblDate3.Text = FT2.Date;
            lblDate4.Text = FT3.Date;
            lblDate5.Text = FT4.Date;
            lblDate6.Text = FT5.Date;
            lblTime1.Text = FT0.DepartureTime;
            lblTime2.Text = FT1.DepartureTime;
            lblTime3.Text = FT2.DepartureTime;
            lblTime4.Text = FT3.DepartureTime;
            lblTime5.Text = FT4.DepartureTime;
            lblTime6.Text = FT5.DepartureTime;
            lblATime1.Text = FT0.ArrivalTime;
            lblATime2.Text = FT1.ArrivalTime;
            lblATime3.Text = FT2.ArrivalTime;
            lblATime4.Text = FT3.ArrivalTime;
            lblATime5.Text = FT4.ArrivalTime;
            lblATime6.Text = FT5.ArrivalTime;
        }
    }
}
