using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern5
    {
        static void Main(string[] args)
        {


            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();

            }
        }
    }
}
//Output..
/*5 5 5 5 5
  4 4 4 4
   3 3 3
    2 2
     1*/

