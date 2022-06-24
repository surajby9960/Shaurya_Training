using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Collection
{
    class Linkedlist1
    {
        //it use store data use doubley linkedlist.
        // advanege=insertion and deletion is faster.no shofiting is needed.

        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(60);
            ll.AddLast(80);
            ll.AddLast(60);
            ll.AddFirst(70);
            LinkedListNode<int> addr = ll.Find(60);// here firstly find of address and then
            ll.AddAfter(addr,100);//pass here addre with new data
            ll.Remove(60);
            foreach(int dt in ll)
            {
                Console.WriteLine(dt);
            }
        }
    }
}
