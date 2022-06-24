using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.OOPs
{
    class demo
    {
        
        const float pi = 3.14f;       //const is bydefult static.this is complie time constatt,value never change;
        readonly string s = "name";   // one way to set value or
        readonly int num;             //other u set using constructor;this is run time constant.

        public demo(int num)
        {
            this.num = num;
        }

        static void Main(string[] args)
        {
            
            demo d = new demo(20);
            Console.WriteLine(demo.pi);
        }
    }
}
