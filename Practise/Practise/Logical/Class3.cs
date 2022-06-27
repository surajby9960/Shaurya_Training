/*using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Class3
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 4, 8, 2, 5, 4, 1 };
            bool isp = true;
            int cnt = 0;
            for(int i=0;i<arr.Length;i++)
            {
                for(int k=arr[i]-1;k>=0;k--)
                {
                    if (arr[i] == arr[k])
                    {
                        isp = true;
                        break;
                    }
                    else
                        isp = false;
                }
                
                if(isp==false)
                {
                    for(int j=0;j<arr.Length;j++)
                    {
                        if (arr[i] == arr[j])
                            cnt++;
                    }

                }
                Console.WriteLine(arr[i] + "" + cnt);
            }
            //Console.WriteLine(arr[i]+""+cnt);
        }
    }
}
*/