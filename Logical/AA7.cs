using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class AA7
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 4]
           { { 1,2,3,4},
            {5,6,7,8}};

            int m = 2;
            int n = 4;

            int max=0;
            for (int i = 0; i < m; i++)
            {

                int s = 0;
                int e = n - 1;
                 max = arr[i, e];

                while (s < e)
                {
                    if (arr[i, s] >max)
                    {
                        max = arr[i, s];
                        
                       
                    }

                }

            }
            for (int i = 0; i < m; i++)

            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(max);
                }
                Console.WriteLine();
            }

        }
    }
}
