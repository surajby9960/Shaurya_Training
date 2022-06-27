using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPS.GENERICS
{
    class Class3
    {
        static void Main(string[] args)
        {
            HashSet<String> hs = new HashSet<string>() { "A", "b", "c" };
            List<string> ls = new List<string>();
            ls.Add("aadi");
            ls.Add("nav");
            ls.Add("vid");
            ls.Add("dia");
            ls.Add("rehan");
            HashSet<string> hs1 = new HashSet<string>(ls);
        }
    }
}
