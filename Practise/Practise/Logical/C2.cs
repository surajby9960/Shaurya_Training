using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class C2
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[4];
            int[] a = { 1, 2, 3, 4 };
            for (int i = 0; i < a.Length; i++)

            {
                Console.Write(a[i]);
            }
            for (int j = a.Length - 1; j >= 0; j--)
            {
                Console.Write(a[j]);
            }
        }
    }
}
