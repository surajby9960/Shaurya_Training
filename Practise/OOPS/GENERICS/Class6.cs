using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace OOPS.GENERICS
{
    class Class7
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("suraj", 56.2f);
            s.Add("sunil", 54.2f);
            s.Add("aher", 66.2f);
            foreach(DictionaryEntry d in s)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }

        }
    }
}
