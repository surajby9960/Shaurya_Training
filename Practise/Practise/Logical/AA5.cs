using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class AA5
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,-1,-2,-3};
            int cp = 0;
            int cn = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    cp++;
                else
                    cn++;
            }

            int[] arrp = new int[cp];
            int[] arrn = new int[cn];
            int p = 0;
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arrp[p] = arr[i];
                    p++;
                }
                else if (arr[i] < 0)
                {
                    arrn[n] = arr[i];
                    n++;
                }
            }
           
            int n1 = 0;
            int n2 = 0;
            int j = 0;
           while(n1<arrn.Length&&n2<arrp.Length)
           {
                arr[j] = arrn[n1];
                j++;
                n1++;
                arr[j] = arrp[n2];
                j++;
                n2++;
           }
           while(n1<arrn.Length)
           {
                arr[j] = arrn[n1];
                n1++;
                j++;
           }
           while(n2<arrp.Length)
           {
                arr[j] = arrp[n2];
                j++;
                n2++;
           }
           foreach (int res in arr)
           {
                Console.Write(res);
           }

            
        }
}   }
