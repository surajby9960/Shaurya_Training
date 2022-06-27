using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Secondhigh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num;
            int large=0;
            int seclarge = 0;
            while (num > 0)
            {
                int rem = num % 10;
                if (large < rem)
                {
                    seclarge = large;
                    large = rem;
                }
                else if (rem >= seclarge)
                    seclarge = rem;
                num = num / 10;
            }
            Console.WriteLine(seclarge);




            
            
        }
    }
}
