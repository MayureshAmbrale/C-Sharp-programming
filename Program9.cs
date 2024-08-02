using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    internal class Program
    {
        static int CountFactor(int no)
        {
            int i = 0;
            int iCnt = 0;
            for (i = 1; i < no; i++)
            {
                if (no % i == 0)
                {
                    iCnt = iCnt + 1;
                }
            }
            return iCnt;
        }
        static void Main(string[] args)
        {
            int Ret = 0;
            Console.WriteLine("Enter the number :");
            int No1 = Convert.ToInt32(Console.ReadLine());

            Ret = CountFactor(No1);
            Console.WriteLine("Count of factors is :" + Ret);
        }
    }
}
