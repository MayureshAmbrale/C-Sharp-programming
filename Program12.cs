using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program12
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int fact = 1;
            while(n>0)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int no = Convert.ToInt32(Console.ReadLine());

            int Ret = 0;
            Ret = Factorial(no);
            Console.WriteLine("Factorial is : " + Ret);
        }
    }
}
