using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    class Parent
    {
        public virtual void Study()
        {
            Console.WriteLine("read the book");
        }
    }
    class Child:Parent
    {
        public  override void Study()
        {
            Console.WriteLine("learning by videos");
        }
    }
    class Subchild:Child
    {
        public override void Study()
        {
            Console.WriteLine("learning by youtube;");
        }
    }
    class Main1
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Study();
            Child c = new Child();
            c.Study();
            Parent p1 = new Child();
            p1.Study();
            Subchild s = new Subchild();
            s.Study();
            p1 = new Subchild();
            p1.Study();
        }
    }
}
