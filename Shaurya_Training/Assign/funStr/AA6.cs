using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.funStr
{
    class AA6
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2,4]
            { { 1,2,3,4},
            {5,6,7,8}};

            int m = 2;
            int n = 4;

            for(int i=0;i<m;i++)
            {
                
                int s = 0;
                int e = n - 1;

                while(s<e)
                {
                    int temp = arr[i, s];
                    arr[i, s] = arr[i, e];
                    arr[i, e] = temp;
                    s++;
                    e--;
                }

            }
            for(int i=0;i<m;i++)

            {
                for(int j=0;j<n;j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }



          
        }
    }
}
