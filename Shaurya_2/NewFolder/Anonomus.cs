using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_2.NewFolder
{
    //here no need to write function seprate you can directly assign.
    class Mathh1
    {
        

        public static void sub(int a, int b)
        {
            Console.WriteLine("sub=" + (a - b));
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine("mul=" + (a * b));
        }
    }
    public delegate void del1(int a,int b);
    public delegate int del2(int a, int b);
    class Anonomus
    {
       /* static int add1(int a,int b)
        {
            return a + b;
        }*/
        static void Main(string[] args)
        {
            del1 d1 = delegate (int a, int b)//here you mak
                {
                    Console.WriteLine("annonomus method"+(a+b));
                };
            d1(10, 2);
            Console.WriteLine( "---------------------------");
            //lamda expr
            //


            del1 d2 = (a, b) =>//here no need to specify data type beacause when already declare when creating delegate
              {
                  Console.WriteLine("lamda=" + (a + b));
              };
            d2(5, 5);
            // del1 d2 = (a, b) => Console.WriteLine("lamda another way="+(a+b));   you declare lamda like this also.
            Console.WriteLine(  "------------------------");

            del2 d3 = (a, b) => a + b;
            Console.WriteLine("answer=" + d3(10, 20));
        }
    }
}
