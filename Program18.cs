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
        public int SumDigits()
        {
            int Sum = 0;
            int d = 0;
            while (No > 0)
            {
                d = No % 10;
                Sum = Sum + d;
                No = No / 10;
            }
            return Sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int Ret = 0;
            Digits dg = new Digits(n);
            Ret = dg.SumDigits();

            Console.WriteLine("Total sum of  digits is :" + Ret);
        }
    }
}
