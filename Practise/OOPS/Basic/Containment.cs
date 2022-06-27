using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    class Containment
    {
        int id;
        int name;
        Book a;
        public int Id { get => id; set => id = value; }
        public int Name { get => name; set => name = value; }
        public Book A { get => a; set => a = value; }
    }
    class Book
    {
        String bname;
        int price;

        public Book(string bname, int price)
        {
            this.bname = bname;
            this.price = price;
        }
        public Book()
        {

        }

        public string Bname { get => bname; set => bname = value; }
        public int Price { get => price; set => price = value; }
    }
    class CTest
    {
        static void Main(string[] args)
        {
            Containment c = new Containment();
            c.A= new Book();
            c.A.Bname = "Rich dad poor dad";
            c.A.Price = 200;
            Console.WriteLine(c.A.Bname+" "+c.A.Price);
        }
    }
}
