using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.OOPs
{
    class Containment
    {
        int sid;
        string sname;
        Book b;

        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        internal Book B { get => b; set => b = value; }
    }
    class Book
    {
        int bid;
        string bname;
        public Book()
        {

        }
        public int Bid { get => bid; set => bid = value; }
        public string Bname { get => bname; set => bname = value; }
    }
    class main1
    {
        static void Main(string[] args)
        {


            Containment c = new Containment();

            c.B = new Book();
           var bidy= c.B.Bid = 24;

            Console.WriteLine(bidy);
        }
    }
}
