using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    interface IIceCreame
    {
        public void eat();
    }
    interface IJuice
    {
        public void drink();
    }
    class Mastani : IIceCreame, IJuice
    {
        public void eat()
        {
            Console.WriteLine("you can eat mastani");
        }
        public void drink()
        {
            Console.WriteLine("you can drink mastani");
        }
    }
    class Mas
    {
        static void Main(string[] args)
        {
            Mastani ms = new Mastani();
                ms.drink();
                ms.eat();
        }
    }
}
