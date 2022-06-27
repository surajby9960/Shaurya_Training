using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Shaurya_Training.Assign.Collection_assign
{
    class Colle5
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "suraj");
            ht.Add(2, "suraj");
            ht.Add(3, "raj");
            ht.Add(4, "sunil");
            Console.WriteLine("enter key");
            Object key =Console.ReadLine();
            Console.WriteLine("enter value");
            Object value = Console.ReadLine();
            ht[key] = value;
            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+"  ="+kv.Value);
            }
        }
    }
}
