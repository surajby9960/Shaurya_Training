using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern13
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 5; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=5;k>=i;k--)
                {
                    Console.Write(k+" ");
                }
                
                Console.WriteLine();
            }
        } 
    }
}
