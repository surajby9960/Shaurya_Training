using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two no");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("+ Addition -subtraction *multiplication /division");
            char ch =Convert.ToChar(Console.Read());
            switch(ch)
            {
                case '+': Console.WriteLine(num1+num2);
                    break;
                case '-': Console.WriteLine(num1-num2);
                    break;
                case '*': Console.WriteLine(num1*num2);
                    break;
                case '/': Console.WriteLine(num1/num2);
                    break;
                default: Console.WriteLine("wrong choice!");
                    break;
            }

        }
    }
}
