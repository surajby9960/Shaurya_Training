using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.funStr
{
    class Class1
    {
        static void Main(string[] args)
        {
            StringBuilder sbb = new StringBuilder("suraj");
            Console.WriteLine(sbb);
            sbb.AppendLine("yadav");
            Console.WriteLine(sbb);
            sbb.Append("a.nagar");
            Console.WriteLine(sbb);
            sbb.Insert(4, "babasaheb");
            Console.WriteLine(sbb);
            sbb.Replace('s', 'b');
            Console.WriteLine(sbb);
            sbb.AppendJoin('b', sbb[3]);
            Console.WriteLine(sbb);
        }
    }
}
