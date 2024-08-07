using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program25
{
    class Array
    {
        public void Display(int[] arr)
        {
            Console.WriteLine("Elements of array are :");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number in array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements in array :");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array a = new Array();
            a.Display(arr);



        }
    }
}
