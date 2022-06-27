using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    class StaticCon
    {
        int id;
        static string name;
        public StaticCon()
        {

        }
        public StaticCon(int i)
        {
            id = i;
            Console.WriteLine(id);
        }
        static StaticCon()
        {
            name = "suraj";
            Console.WriteLine(" static Constructor"+name);
        }

    }
    class ConTest
    {
        static void Main(string[] args)
        {
            StaticCon s = new StaticCon(10);
        }
    }
}
