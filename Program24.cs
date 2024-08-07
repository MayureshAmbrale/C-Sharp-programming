
/*
 Given an unsorted array and a number n, find if there exists a pair of elements in the array whose difference is n. 
Input: arr[] = {5, 20, 3, 2, 50, 80}, n = 78
Output: Pair Found: (2, 80)

Input: arr[] = {90, 70, 20, 80, 50}, n = 45
Output: No Such Pair
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total numbers in array :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter numbers in array :");
            int i = 0;
            for(i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the difference :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for(i=0;i<n;i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if (arr[j] - arr[i] == n1)
                    {
                        Console.WriteLine("Pari found :" + arr[i] +" "+ arr[j]);
                    }
                }
            }
        }
    }
}
