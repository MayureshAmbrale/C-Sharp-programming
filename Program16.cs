﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace program14
{
    class Digits
    {
        int No;

        public Digits(int no)
        {
            this.No = no;
        }
        public int CountEvenDigits()
        {
            int iCnt = 0;
            int d = 0;
            while (No > 0)
            {
                d = No % 10;
                if(d%2==0)
                iCnt++;
                No = No / 10;
            }
            return iCnt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int Ret = 0;
            Digits dg = new Digits(n);
            Ret = dg.CountEvenDigits();

            Console.WriteLine("Total number of digits are :" + Ret);
        }
    }
}
