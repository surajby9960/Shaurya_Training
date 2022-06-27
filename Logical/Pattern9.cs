using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern9
    {
        static void Main(string[] args)
        {
            int n = 1;
                for(int i=1;i<=5;i++)
           {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n++ +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
