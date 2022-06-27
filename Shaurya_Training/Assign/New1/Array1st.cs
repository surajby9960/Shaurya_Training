using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.New1
{
    class Array1st
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 14, 12, 4, 7, 85 };
            int p = arr.Length - 1;
            
            for (int i = 0; i < arr.Length/ 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[p];
                arr[p] = temp;
                p--;
            }
            
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            int[] a1 = { 1, 2, 3, 4, 5, 6 };
            int[] a2 = { 2, 7, 8, 5, 2, 4, 8 };
            int[] a3 = new int[13];
            int k = 0;
          for(int i=0;i<a1.Length;i++)
            {
                
            }
        }
    }
}        