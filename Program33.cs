using System;

namespace program33
{
    class Array
    {
        public static  void ReverseArray(int[] Brr)
        {
            int temp=0,start=0,end=0;
            for(start=0,end=Brr.Length-1;start<end;start++,end--)
            {
                temp = Brr[start];
                Brr[start] = Brr[end];
                Brr[end] = temp;
            }
            Console.WriteLine();
            
        }
        public static void Main()
        {
            

            Console.WriteLine("Enter total numbers of elements in array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int i = 0;
            Console.WriteLine("Enter elements in array");
            for (i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array before swaping :");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            ReverseArray(arr);
            Console.WriteLine("Array after swaping :");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }

}
