using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    internal class Program
    {
        static bool CheckPrime(int no)
        {
            bool bFlag = false;
            if (no < 0)
            {
                Console.WriteLine("Entered number is negative ");
                return bFlag;
            }
            int i = 0;
            int icnt = 0;
            for (i = 1; i <= no / 2; i++)
            {
                if (no % i == 0)
                {
                    icnt++;
                }
            }
            if (icnt == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] a)
        {
            bool bRet = false;
            Console.WriteLine("Enter number :\n");
            int no = Convert.ToInt32(Console.ReadLine());
            bRet = CheckPrime(no);
            if (bRet == true)
            {
                Console.WriteLine("Entered number is prime number\n");
            }
            else
            {
                Console.WriteLine("Entered number is not prime number\n");
            }
        }
    }
}
