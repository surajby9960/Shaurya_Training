using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern11
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i==j||j==1||i==5)
                    {
                        Console.Write("* ");
                    }
                    else Console.Write(" ");

                   
                }
                Console.WriteLine();
            }
        }
    }
}
