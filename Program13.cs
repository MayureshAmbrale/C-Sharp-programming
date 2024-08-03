using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace program12
{
    internal class Program
    {
        public static long fact = 1;
        static long Factorial(int n)
        {
           
            if(n!=0)
            {
                fact = fact * n;
                
                Factorial(n - 1);
                return fact;

            }

            return fact;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int no = Convert.ToInt32(Console.ReadLine());

            long Ret = 0;
            Ret = Factorial(no);
            Console.WriteLine("Factorial is : " + Ret);
        }
    }
}
