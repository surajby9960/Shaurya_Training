using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.New1
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int n = int.Parse(Console.ReadLine());
            int max = n%10;
             n = n / 10;
            int isd = 0;
            int cnt = 0;
            int isi = 0;
            
            while(n>0)
            {
                int res = n % 10;
                if(max>res)
                {
                    max = res;
                    isd++;

                }
                else if(max<res)
                {
                    max = res;
                    isi++;
                }
                n = n / 10;
                cnt++;
            }
            if(isd==cnt)
                Console.WriteLine("Increasing");
            else if(isi==cnt)
                Console.WriteLine("Decrasing");
            else
                Console.WriteLine("bouncy");

            int[] arr = new int[5];
            Console.WriteLine("enter the 5 no");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int mx = 0;
            for(int k=0;k<arr.Length;k++)
            {
                if(mx<arr[k])
                {
                    mx = arr[k];
                }
            }
            Console.WriteLine(mx);
        }
    }
}
