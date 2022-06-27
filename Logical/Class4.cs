using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Class4
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50, 60 };
            int sum = 0;
            for(int i=0;i<a.Length-1;i=i+2)
            {
                sum = a[i] + a[i + 1];
                Console.WriteLine(sum);
            }
            Console.WriteLine("enter any number");
            int n = int.Parse(Console.ReadLine());
        

        }
    }
}
