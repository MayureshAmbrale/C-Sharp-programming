using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program34
{
    internal class Program
    {
        public static bool CheckChar(char c)
        {
            bool bFlag = false;

            if(c>='A' && c<='Z')
            {
                bFlag = true;
            }
            return bFlag;
        }
        static void Main(string[] args)
        {
            bool bRet = false;
            Console.WriteLine("Enter character :");
            char ch = Convert.ToChar(Console.ReadLine());

            bRet = CheckChar(ch);
            if(bRet==true)
            {
                Console.WriteLine("Character is Capitai ");
            }
            else
            {
                Console.WriteLine("Character is not Capital");
            }


        }
    }
}
