using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.New1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 8, 0, 2, 0, 1, 4, 7 };
            int min = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("minimun="+min);
            //-------------------count odd element
            int cnt = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2!=0)
                {
                    cnt++;
                }
            }
            Console.WriteLine("no od odd element="+cnt);
            //--------no is present or not
            Console.WriteLine("enter number you want to check");
            int num = Convert.ToInt32(Console.ReadLine());
            bool ispresent = false;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==num)
                {
                    ispresent = true;
                    break;
                }
            }
            if(ispresent)
                Console.WriteLine($"ni is present in array");
           else
                Console.WriteLine("not present in array");
            //=-------------
        
        }
    }
}
