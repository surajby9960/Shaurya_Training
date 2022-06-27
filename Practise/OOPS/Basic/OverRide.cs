using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    class OverRide
    {
        public virtual void Add()
        {
            Console.WriteLine();
        }
    }
    class BB:OverRide
    {
        public override void Add()
        {
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            BB b = new BB();
            b.Add();
        }
    }
}
//1
 
