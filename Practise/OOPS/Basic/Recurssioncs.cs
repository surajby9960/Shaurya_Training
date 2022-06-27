using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    class Recurssioncs
    {
        public static int fact(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                int ans = fact(n - 1);
                return n * ans;
            }
            
        }
        static void Main(string[] args)
        {
            int r = fact(3);
            Console.WriteLine("fact" + r);
        }

    }

}
