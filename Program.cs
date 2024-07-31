using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        public static bool CheckDivisible3and5(int no)
        {
            bool bFlag = false;
            if (no % 3 == 0 && no % 5 ==0)
            {
                bFlag = true;
            }

            return bFlag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int No1 = Convert.ToInt32(Console.ReadLine());
            bool Ret = false;
            Ret = CheckDivisible3and5(No1);
            if (Ret == true)
            {
                Console.WriteLine("Number is divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("Number is divisible by 3 and 5");
            }

        }
    }
}
