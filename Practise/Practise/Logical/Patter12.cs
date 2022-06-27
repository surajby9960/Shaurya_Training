using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Patter12
    {
        static void Main(string[] args)
        {
            char a = (char)63;
                for(int i=1;i<=5;i++)
            {

                for(int j=1;j<=i;j++)
                {
                    Console.Write($"{a=(char)(a+2)}  ") ;
                }
                Console.WriteLine();
            }
        }
    }
}
