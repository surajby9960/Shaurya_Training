using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern3
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
                    Console.Write("");
                }
                for(int n=2;n<=i;n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
