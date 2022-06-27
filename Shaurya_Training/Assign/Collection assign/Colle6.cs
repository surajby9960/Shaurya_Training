using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Shaurya_Training.Collection
{
    class Colle6
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(101, "prahati");
            h.Add(102, "keshav");
            h.Add(103, "aarati");
            h.Add(104, "aaaaksh");
            h.Add(105, "ravi");
            h.Add(106, "raj");
             
            foreach(DictionaryEntry de in h)
            {
                Console.WriteLine(de.Key+"="+de.Value);
            }
        }
    }
}
