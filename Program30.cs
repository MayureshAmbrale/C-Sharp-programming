using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program25
{
    class Array
    {
        public bool Search(int[] arr, int no)
        {
            bool bFlag = false;
            int i = 0;int j = 0;
            for(i=0,j=arr.Length;i<j;i++,j--)
            {
                if (j == no || i==no)
                {
                    bFlag = true;
                    break;
                }
            }
            return bFlag;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool ret = false;
            Console.WriteLine("Enter total number in array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements in array :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number to search :");
            int no = Convert.ToInt32(Console.ReadLine());
            Array a = new Array();
            ret = a.Search(arr, no);

            if (ret == true)
            {
                Console.WriteLine("Number is present in array ");
            }
            else
            {
                Console.WriteLine("Number is not present in array ");
            }



        }
    }
}
