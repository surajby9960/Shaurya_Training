using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_2.NewFolder
{
   
        public delegate void myde(string nm, string addr);
        public delegate int mydel(int n);
        class Demodel
        {
            public static void info(string nm, string addre)
            {
                Console.WriteLine("name=" + nm + " address=" + addre);
            }
            public static int facto(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            static void Main(string[] args)
            {
               // Console.WriteLine("Mainnnnnnnnnnnnnnn");
                //Console.ReadLine();
                myde md = Demodel.info;
                mydel m = Demodel.facto;
               // Console.WriteLine("hii");
                int res = m(5);
                Console.WriteLine(res);
                md("suraj", "pune");
            }
        }
 }




