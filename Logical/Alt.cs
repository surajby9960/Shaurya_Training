using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Alt
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 4, 7,4 };
            int[] arr2 = { 1, 23, 2 };
            int[] arr3 = new int[7];
            int i = 0; int j = 0;int k = 0;
            int l1= arr1.Length;
            int l2 = arr2.Length;
          
            while (i<l1&&j<l2)
            {
                arr3[k] = arr1[i];
                k++;
                i++;
                arr3[k] = arr2[j];
                k++;
                j++;
            }
            while(l1>i)
            {
                
                arr3[k] = arr1[i];
                    
                i++;
            }
            while(l2>j)
            {
                arr3[k] = arr2[j];
                j++;
                k++;
            }
            foreach(int res in arr3)
            {
                Console.WriteLine(res);
            }
            

            
        }
    }
}
