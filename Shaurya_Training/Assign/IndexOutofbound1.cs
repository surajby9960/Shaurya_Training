using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class IndexOutofbound1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            try 
            {
                for (int i = 0; i < 10; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
            } 
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
