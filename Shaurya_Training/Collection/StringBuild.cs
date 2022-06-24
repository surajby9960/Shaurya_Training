using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Collection
{
    class StringBuild
    {
        class mysorted : IComparer<StringBuilder>
        {
            public int Compare(StringBuilder s1, StringBuilder s2)
            {
                return s1.ToString().CompareTo(s2.ToString());
            }
            static void Main(string[] args)
            {



                SortedList<StringBuilder, int> s = new SortedList<StringBuilder, int>(new mysorted ());

                s.Add(new StringBuilder("siya"), 90);
                s.Add(new StringBuilder("riya"), 90);

                foreach (KeyValuePair<StringBuilder, int> kv in s)
                {
                    Console.WriteLine(kv.Key + "  " + kv.Value);
                }
            }
        }
    }
}
