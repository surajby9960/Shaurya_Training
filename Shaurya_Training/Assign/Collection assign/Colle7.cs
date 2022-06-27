using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Shaurya_Training.Assign.Collection_assign
{
    class Colle7
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            ht.Add(5, "five");
            ht.Add(6, "six");
            ht.Add(7, "seven");
            ht.Add(8, "eight");
            ht.Add(9, "nine");
            ArrayList ar = new ArrayList();

            foreach(DictionaryEntry item in ht)
            {
                int n = Convert.ToInt32(item.Key);
                if(n%3!=0)
                {
                    ar.Add(item);
                }
            }
            for(int i=0;i<ar.Count;i++)
            {
                ht.Remove(ar[i]);
            }
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+"="+d.Value);
            }
        }
    }
}
