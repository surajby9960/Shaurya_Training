using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.funStr
{
    class Longword
    {
        static void Main(string[] args)
        {
            string str = " i am in Maharahtra";
            string[] s = str.Split(" ");
            Console.WriteLine(s[2]);
        }
    }
}
