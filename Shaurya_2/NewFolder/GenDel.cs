using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_2.NewFolder
{
    class GenDel
    {
        static int add(int a,float b)
        {
            Console.WriteLine("add="+(a+b));
            return (int)(a + b);
        }
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void greet(String s)
        {
            Console.WriteLine("Good Afternoon "+s);
        }
        static void Main(string[] args)
        {
            //Func=if yours method takes n input and return value back.
            //Acion=when method takes n imput and return type void.means nothig return return.
            //predicate=its return bool type;

            Func<int, float, int> f1 = add;
            int ans = f1(10, 5.2f);
           
            
            Predicate<int> p1 = isEven;
            Console.WriteLine(p1(45));
           
            
            Action<string> a1 = greet;
            a1("suraj yadav.");
        }
    }
}
