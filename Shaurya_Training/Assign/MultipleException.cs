using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class MultipleException
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
                try
                {
                    Console.WriteLine("enter any number");
                    int a = int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                string s = null;
                Console.WriteLine(s.ToLower());
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }
           
            catch(NullReferenceException nr)
            {
                Console.WriteLine(nr.Message);
            }
        }
    }
}
