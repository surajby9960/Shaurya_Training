using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPS.Collection
{
    class Sort
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("suraj");
            array.Add("sunil");
            array.Add("ajit");
            array.Add("nitin");
            array.Add("rushhi");
            array.Add("mandar");
            int j = array.Count-1;
            for (int i = 0; i < array.Count / 2; i++)
            {
                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            foreach(var x in array)
            {
                Console.Write(x);
            }
            array.Reverse();
            Console.WriteLine();
            foreach (var y in array)
            {
                Console.Write(y);
            }

        }
    }
}
