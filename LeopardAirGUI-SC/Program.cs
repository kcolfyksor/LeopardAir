using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace leopardair_wfa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Membership memberlist = new Membership();
            StreamReader Mreader = null;
            try
            {
                Mreader = new StreamReader("Membership.txt");
            }
            catch(IOException exc)
            {
                MessageBox.Show(exc.Message + "\n\n\nApplication closing.");
                Application.Exit();
            }
            string Mreadin1, Mreadin2;
            double Mreadin3;
            do
            {
                Mreadin1 = Mreader.ReadLine();
                Mreadin2 = Mreader.ReadLine();
                Mreadin3 = Convert.ToDouble(Mreader.ReadLine());
                memberlist.Register(Mreadin1, Mreadin2, Mreadin3);
            } while (Mreadin1 != null || Mreadin2 != null);
            Mreader.Close();


            Flight[] FD = new Flight[6];
            StreamReader Freader = null;
            try
            {
                Freader = new StreamReader("Flight.txt");
            }
            catch(IOException exc)
            {
                MessageBox.Show(exc.Message + "\n\n\nApplication closing.");
                Application.Exit();
            }
            string Freadin1, Freadin2, Freadin3, Freadin4, Freadin5, Freadin6;
            double Freadin7;
            for (int a = 0; a < 6; a++)
            {
                Freadin1 = Freader.ReadLine();
                Freadin2 = Freader.ReadLine();
                Freadin3 = Freader.ReadLine();
                Freadin4 = Freader.ReadLine();
                Freadin5 = Freader.ReadLine();
                Freadin6 = Freader.ReadLine();
                Freadin7 = Convert.ToDouble(Freader.ReadLine());
                FD[a] = new Flight(Freadin1, Freadin2, Freadin3, Freadin4, Freadin5, Freadin6, Freadin7);
            }
            Freader.Close();
            
            Airport[] theairport = new Airport[4];
            StreamReader Areader = null;
            try
            {
                Areader = new StreamReader("Airport.txt");
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message + "\n\n\nApplication closing.");
                Application.Exit();
            }
            string Areadin1, Areadin2, Areadin3;
            for (int b = 0; b < 4; b++)
            {
                Areadin1 = Areader.ReadLine();
                Areadin2 = Areader.ReadLine();
                Areadin3 = Areader.ReadLine();
                theairport[b] = new Airport(Areadin1, Areadin2, Areadin3);
            }
            Areader.Close();

            FD[0].AddAirport(theairport[0], theairport[1]);
            FD[1].AddAirport(theairport[0], theairport[2]);
            FD[2].AddAirport(theairport[0], theairport[3]);
            FD[3].AddAirport(theairport[0], theairport[1]);
            FD[4].AddAirport(theairport[0], theairport[2]);
            FD[5].AddAirport(theairport[0], theairport[3]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginMenu(memberlist, FD[0], FD[1], FD[2], FD[3], FD[4], FD[5]));
        }
    }
}
