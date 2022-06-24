using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.OOPs
{
  
        class Program
        {


            public void m1()
            {
                Console.WriteLine("in m1 parent");
            }
            public virtual void m2()
            {
                Console.WriteLine("in m2 parent");
            }
        }
        class P : Program
        {
            public new void m1()
            {
                Console.WriteLine("in child m1");
            }
            public override void m2()
            {
                Console.WriteLine("in child m2");

            }

            static void Main(string[] args)
            {
                Program p = new Program();
                p.m1();
                p.m2();
                Program p1 = new P();
                p1.m1();
                p1.m2();
                P p2 = new P();
                p2.m1();


            }
        }
    
}
