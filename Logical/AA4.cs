using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class AA4
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 0, 4, 70, 12, 0, 6, 0 };
           // int j = 1;
           /* for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]<arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }*/
            
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[cnt] = arr[i];
                    cnt++;
                }

            }               
                while(cnt<arr.Length)
                {
                    arr[cnt] = 0;
                    cnt++;
                }
                foreach (int res in arr)
                {
                    Console.WriteLine(res);
                }
            string str = "India is my cuntryl";
            string s = " ";
            for(int i=0;i<str.Length;i++)
            {
                s = str[i] + s;
            }
            Console.WriteLine("reverse is="+s);

            //--------------------------------
           // string str1 = "India is my country";
            string[] s1 = str.Split(" ");
            string word = "";
            for(int i=0;i<s1.Length;i++)
            {
                string s2 = s1[i];
                string str1 = "";
                for(int j=0;j<s2.Length;j++)
                {
                    str1 = s1[i] + str1;
                }
                word = word + str1 + " ";

            }
            Console.WriteLine(word);
        
        
        
        
        }


    }
}
