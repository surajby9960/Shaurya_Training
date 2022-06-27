using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//collection 2 Q5.
namespace OOPS.GENERICS
{
    class Class6
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(1, "ravi");
            sl.Add(2, "ravindra");
            sl.Add(3, "ravi jadeja");
            foreach(DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}
