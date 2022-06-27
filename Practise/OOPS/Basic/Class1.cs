using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    class A

    {
        public  virtual void M1()
        {
            Console.WriteLine("m1 method of A class");
        }
        public void M2()
        {
            Console.WriteLine("M2 method of A class");
        }
    }
    class B:A
    {
        public  override void M1()
        {
            Console.WriteLine(" M1 of B class");
        }
        public new void M2()
        {
            Console.WriteLine("M2 of B class");
        }
    }
    class C:B
    {
        public override void M1()
        {
            Console.WriteLine("M1 of C class");
        }
    }
    class D
    {
       static void M3()
       {
            Console.WriteLine("Staric M3 method");

       }
    }
    class AA
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.M1();
           // Console.ReadLine();
            
        }
    }
}
