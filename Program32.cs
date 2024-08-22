using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program25
{
    class Array
    {
        public int Minimum(int[] arr)
        {
            int i = 0; int j = 0;
            int min = arr[0];
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
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
            ret = a.Minimum(arr);

            Console.WriteLine("Minimum number in array is :" + ret);





        }
    }
}
