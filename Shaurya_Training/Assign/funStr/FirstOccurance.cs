﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.funStr
{
    class FirstOccurance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            Console.WriteLine($"first occurce is{arr[0]}");

        }
    }
}
