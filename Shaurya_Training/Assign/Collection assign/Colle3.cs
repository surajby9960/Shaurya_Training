using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.Collection_assign
{
    class Colle3
    {
        public static int poten(string ss)
        {
            int sum = 0, a;
            for(int j=0;j<ss.Length;j++)
            {
                if(ss[j]>='A'&&ss[j]<='Z')
                {
                    a = ss[j] - 64;
                    sum = sum + a;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string:");
            string ss = Console.ReadLine();
            ss = ss.ToUpper();
            string[] arr = ss.Split();
            for(int i=0;i<arr.Length;i++)
            {
                for (int j =0;j<arr.Length-1-i;j++)
                {
                    if(poten(arr[j])>poten(arr[i]))
                    {
                        string t = arr[j];
                        arr[j] = arr[i];
                        arr[i] = t;
                    }
                }
            }
            foreach(string st in arr)
            {
                Console.WriteLine(st+" ");
                Console.WriteLine();
            }
        }
    }
}
