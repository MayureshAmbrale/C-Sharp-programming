using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    internal class Program
    {
        static bool CheckPerfect(int no)
        {
            int i = 0;
            int iSum = 0;
            for (i = 1; i <=no/2; i++)
            {
                if (no % i == 0)
                {
                    iSum = iSum + i;
                }
            }
            
            if (iSum == no)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool Ret = false;
            Console.WriteLine("Enter the number :");
            int No1 = Convert.ToInt32(Console.ReadLine());

            Ret = CheckPerfect(No1);

            if(Ret== true)
            {
                Console.WriteLine("Given number is perfect number ");
            }
            else
            {
                Console.WriteLine("Given number is not perfect number ");

            }
        }
    }
}
