using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern4
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=i;k<=5;k++)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Output..
   /*5
    4 5
   3 4 5
  2 3 4 5
 1 2 3 4 5*/