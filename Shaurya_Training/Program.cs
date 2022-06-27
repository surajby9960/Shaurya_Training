using System;
using System.Collections.Generic;

namespace Shaurya_Training
{
    class stude
    {
        static void Main(string[] args)
        {
            string s = "suraj babasaheb yadav";
            char[] ch = s.ToCharArray();
            Console.WriteLine(ch[2]);
            s= s.Remove(16);
             s=s.Insert(16, "suraj");
            Console.WriteLine(s);

        }  
    }
   
}
