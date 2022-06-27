using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Jaggad
    {
        static void Main(string[] args)
        {
            int[][]jarr= new int[3][];
            jarr[0] = new int[3];
            jarr[1] = new int[5];
            jarr[2] = new int[2];
            Console.WriteLine("enter element in jagged array");
            for(int i=0;i<jarr.GetLength(0);i++)
            {
                for(int j=0;j<jarr[i].Length;j++)
                {
                    jarr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < jarr.GetLength(0); i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j]);

                }
                Console.WriteLine();
            }
        }
    }
}
