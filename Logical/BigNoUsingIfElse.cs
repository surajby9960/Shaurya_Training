using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class BigNoUsingIfElse
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter three no abc");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if(a>b)
            {
                if(b>c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else if(b>c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
