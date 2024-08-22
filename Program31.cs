using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program25
{
    class Array
    {
        public int Maximum(int[] arr)
        {
            int i = 0; int j = 0;
            int max = arr[0];
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int ret = 0;
            Console.WriteLine("Enter total number in array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements in array :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array a = new Array();
            ret = a.Maximum(arr);

            Console.WriteLine("Maximum number in array is :" + ret);

            



        }
    }
}
