using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
}
