﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % 1 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}