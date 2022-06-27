using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Emter any no:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            int n1 = n;


            while (n > 0)
            {
                int r = n % 10;
                if(temp<r)
                {
                    temp = r;
                }
                n = n / 10;
            }
            int big = temp;
            n = n1;
            temp = 0;
            while(n>0)
            {
                int r1 = n % 10;
                if(r1!=big)
                {
                    if(temp<r1)
                    {
                        temp = r1;
                    }
                }
                n = n / 10;
            }
               Console.WriteLine(temp);
        }
    }
}
