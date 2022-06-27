using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.MyExcption
{
    class Basic
    {
        static string s;
    }
    class Test
    {
        public void op()
        {
            Console.WriteLine("enter moble no:");
            long num = long.Parse(Console.ReadLine());
            int c = 0;
            while (num > 0)
            {
                c++;
                num = num / 10;
            }
            if(num==10)
            {
                Console.WriteLine("valid");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hii");
            try
            {
                //string s;
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                //Console.WriteLine(s.ToLower());
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message+"null");
            }
            catch(SystemException)
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("end");


        }
    }
}
