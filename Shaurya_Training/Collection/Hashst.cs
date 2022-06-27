using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Collection
{
    class Hashst
    {
        //to store unique object.not store duplicate
        //
        static void Main(string[] args)
        {
            HashSet<string> ht = new HashSet<string>();
            ht.Add("om");
            ht.Add("suraj");
            ht.Add("suraj");// here not give error but.they not save this suraj only one suraj save.

            foreach(string st in ht)
            {
                Console.WriteLine(st);
            }

            //when u design custom method u need to oveeride hashcode and equals method.o.w tehy add duplicate object.
        }
    }
}
