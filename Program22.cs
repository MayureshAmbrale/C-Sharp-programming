using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program20
{
    public class Pattern
    {
        public int iRow;
        public int iCol;

        public Pattern(int i, int j)
        {
            this.iRow = i;
            this.iCol = j;
        }
        public void Display()
        {
            int i = 0, j = 0;
            if(iRow!=iCol)
            {
                Console.WriteLine("Number of row and number of column are different ");
                return;
            }
            for (i = 0; i < iRow; i++)
            {
                for (j = 0; j < iCol; j++)
                {
                    if (i>j)
                        Console.Write("* ");
                    

                }
                Console.WriteLine();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows :");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns :");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Pattern p = new Pattern(n1, n2);

            p.Display();
        }
    }
}
