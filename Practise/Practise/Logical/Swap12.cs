using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Swap12
    {
        static void Main(string[] args)
        {
            
            int []ar = { 4, 6, 5, 8, 7, 4, 1 };
            int j = ar.Length-1;
            Console.WriteLine(  j);
            for ( int i = 0;i<ar.Length;i++)
            {
                
                int temp = ar[i];
                ar[i] = ar[j];
                ar[j] = temp;
                j--;
                if (i == 2)
                    break;

               
            }
            foreach(int r in ar)
            {
                Console.WriteLine(r);
            }
        }
    }
}
