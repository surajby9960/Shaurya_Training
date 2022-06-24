using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class Universalexception
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                
                
               Console.WriteLine("enter any number");
               int a = int.Parse(Console.ReadLine());
                
               
                string s = "";
                Console.WriteLine(s.ToLower());
            }
            catch(SystemException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }
}
