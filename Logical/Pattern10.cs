using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern10
    {
        static void Main(string[] args)
        {
            char a = 'A';
            for(int i=1;i<=5;i++)
            { 
                for(int k=5;k>=i;k--)
                {
                    Console.Write(" ");
                }
                
                for(int j=i;j>=1;j--)
                {
                    
                    Console.Write(a+" ");
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
