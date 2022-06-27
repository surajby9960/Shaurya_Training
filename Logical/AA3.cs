using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class AA3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Enter{n} elemnt into Array:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= 9; i++)
            {
                int cnt = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if(i == arr[j])
                    cnt++;

            
                }
                if(cnt>0)
                Console.WriteLine($"Occurcance of{i}is={cnt}");
            }





            foreach(int res in arr)
            {
                Console.WriteLine(res);
            }
        }
    }
}
