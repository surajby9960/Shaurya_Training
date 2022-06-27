using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern8
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write(j+" ");
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
