using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    internal class Program
    {
        static void DisplayFactorual(int no)
        {
            int i = 0;
            for(i=1;i<=no;i++)
            {
                if(no % i== 0)
                {
                    Console.WriteLine(i + " is factor of "+no);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int No1 = Convert.ToInt32(Console.ReadLine());

            DisplayFactorual(No1);
        }
    }
}
