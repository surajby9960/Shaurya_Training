using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern2
    {
        static void Main(string[] args)
        {
                for(int i=1;i<=4;i++)
                {
                  for(int j=4;j>=i;j--)
                {
                    Console.Write(" ");
                }
                  for(int k=1;k<=i;k++)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine();

                }
        }
    }
}
/*Output
    1
   1 2
  1 2 3
 1 2 3 4*/