using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace program14
{
    class Digits
    {
        int No;
        public Digits(int no)
        {
            this.No = no;
        }
        public void DisplayDigits()
        {
            int d =0;
            while(No>0)
            {
                d = No % 10;
                Console.WriteLine(d);
                No = No / 10;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = Convert.ToInt32(Console.ReadLine());

            Digits dg = new Digits(n);
            dg.DisplayDigits();
        }
    }
}
