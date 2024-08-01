using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {   
        public static bool CheckEvenOdd(int no)
        {
            bool bFlag = false;
            if (no % 2 == 0)
            {
                bFlag = true;
            }
           
            return bFlag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int No1=Convert.ToInt32(Console.ReadLine());
            bool Ret = false;
            Ret = CheckEvenOdd(No1);
            if(Ret==true)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is not even");
            }

        }
    }
}
