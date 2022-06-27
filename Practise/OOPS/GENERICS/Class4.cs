using System;
using System.Collections.Generic;
using System.Text;
//Collection 2 Q no 1.
namespace OOPS.GENERICS
{
    class Class4
    {
        static void Main(string[] args)
        {
            List<string> ls = new List<string>() { "suraj0", "gaurv", "natasha", "mayuri" };
            ls.Sort();
            foreach (string l in ls) 
            {
                Console.WriteLine(l);
            }
        }
    }
}
