using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Output..
    /*1
    2 2
   3 3 3
  4 4 4 4
 5 5 5 5 5*/