using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_2.NewFolder
{
    class Class1
    {
        static bool iseven(int a)
        {
            return a% 2 == 0;
        }
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 23, 22, 14, 7, 45, 74, 12 };
            List<int> l2=l1.FindAll((a)=>a%2==0);
        }
    }
}
