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
    public partial class CheckPoints : Form
    {
        Membership memberlist;
        double currentpoints;
        public CheckPoints(Membership Member, string currentusername)
        {
            memberlist = Member;
            InitializeComponent();
            lblUsername2.Text = currentusername;
            currentpoints = memberlist.CurrentPoints(currentusername);
            lblCMP2.Text = Convert.ToString(currentpoints);
        }
    }
}
