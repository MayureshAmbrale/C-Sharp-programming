using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program25
{
    class Array
    {
        public int SumArray(int[] arr)
        {
            int sum = 0;
            Console.WriteLine("Elements of array are :");
            foreach (int j in arr)
            {
                sum = sum + j;
            }
            return sum;
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
            ret=a.SumArray(arr);

            Console.WriteLine("Sum of array is :"+ ret);



        }
    }
}
