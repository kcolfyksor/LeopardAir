using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leopardair_wfa
{
    public class Seat
    {
        private string[,] seating;
        public string[,] Seating
        { get { return seating; } }

        public Seat()
        {
            this.seating = new string[31, 6];
            for (int z = 0; z < 31; z++)
            {
                for (int y = 0; y < 6; y++)
                {
                    this.seating[z, y] = "O";
                }
            }
        }
/*
        public void DisplaySeat()
        {
            Console.WriteLine();
            Console.WriteLine("\t|\t(A)(B)(C)(D)(E)(F)\t|");
            Console.WriteLine("\t|\t\t\t\t|");
            for (int z = 0; z < 12; z++)
            {
                Console.Write("\t|({0})\t", z + 1);
                for (int y = 0; y < 6; y++)
                {
                    Console.Write("[{0}]", seating[z, y]);
                }
                Console.Write("\t|");
                Console.WriteLine();
            }
            for (int z = 13; z < 31; z++)
            {
                Console.Write("\t|({0})\t", z + 1);
                for (int y = 0; y < 6; y++)
                {
                    Console.Write("[{0}]", seating[z, y]);
                }
                Console.Write("\t|");
                Console.WriteLine();
            }
        }
*/
        public double PickSeat(int aRow, string aColumn)
        {
            int boughtrow = aRow - 1;
            int boughtcolumn = 0;
            double seatcost = 0;

            if (aColumn.ToUpper() == "A")
                boughtcolumn = 0;
            else if (aColumn.ToUpper() == "B")
                boughtcolumn = 1;
            else if (aColumn.ToUpper() == "C")
                boughtcolumn = 2;
            else if (aColumn.ToUpper() == "D")
                boughtcolumn = 3;
            else if (aColumn.ToUpper() == "E")
                boughtcolumn = 4;
            else if (aColumn.ToUpper() == "F")
                boughtcolumn = 5;

            if (boughtrow <= 4 || boughtrow == 11 || boughtrow == 12)
            {
                seatcost = 38;
            }
            else
            {
                seatcost = 18;
            }
            seating[boughtrow, boughtcolumn] = "X";
            return seatcost;
        }

        public bool SeatTaken(int bRow, string bColumn)
        {
            int checkrow = bRow - 1;
            int checkcolumn = 0;

            if (bColumn.ToUpper() == "A")
                checkcolumn = 0;
            else if (bColumn.ToUpper() == "B")
                checkcolumn = 1;
            else if (bColumn.ToUpper() == "C")
                checkcolumn = 2;
            else if (bColumn.ToUpper() == "D")
                checkcolumn = 3;
            else if (bColumn.ToUpper() == "E")
                checkcolumn = 4;
            else if (bColumn.ToUpper() == "F")
                checkcolumn = 5;

            for (int w = 0; w < 31; w++)
            {
                for (int v = 0; v < 6; v++)
                {
                    if (seating[checkrow, checkcolumn] == "X")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public double RemoveSeat(int fRow, string fColumn)
        {
            int removingrow = fRow - 1;
            int removingcolumn = 0;
            double removeseatcost = 20;

            if (fColumn.ToUpper() == "A")
                removingcolumn = 0;
            else if (fColumn.ToUpper() == "B")
                removingcolumn = 1;
            else if (fColumn.ToUpper() == "C")
                removingcolumn = 2;
            else if (fColumn.ToUpper() == "D")
                removingcolumn = 3;
            else if (fColumn.ToUpper() == "E")
                removingcolumn = 4;
            else if (fColumn.ToUpper() == "F")
                removingcolumn = 5;

            for (int w = 0; w < 31; w++)
            {
                for (int v = 0; v < 6; v++)
                {
                    if (seating[removingrow, removingcolumn] == "X")
                    {
                        seating[removingrow, removingcolumn] = "O";
                    }
                }
            }
            return removeseatcost;
        }
    }
}
