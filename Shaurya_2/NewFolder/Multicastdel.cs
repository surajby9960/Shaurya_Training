using System;
using System.Collections.Generic;
using System.Text;
//if one delegate point more than one funtin then it called multicasting delegate;
//you can declare delegate anywhere in programe in class also.
namespace Shaurya_2.NewFolder
{
    class Mathh
    {
       public static void add(int a,int b)
        {
            Console.WriteLine("sum="+(a+b));
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine("sub=" + (a - b));
        }

       public static void mul(int a, int b)
        {
            Console.WriteLine("mul=" + (a * b));
        }
    }
    public delegate void myd(int a, int b); 
    class Multicastdel
    {
        static void Main(string[] args)
        {

            
            myd d = Mathh.add;
            d = d + Mathh.sub;
            d += Mathh.mul;//here you give 3 function referece to del d.
            d(5, 4);//this value pass all three function.
            d -= Mathh.sub;//also remove any function.
            Console.WriteLine(  "-------------------");
            d(5, 2);
        }
    }
}
