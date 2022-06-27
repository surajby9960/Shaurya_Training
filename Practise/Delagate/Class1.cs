using System;
using System.Collections.Generic;
using System.Text;

namespace Delagate
{
    class Delegate2
    {
        public static float add(float a,float b)
        {
            return a + b;
        }
        public static void prime(int n)
        {
            bool b = true;
            for(int i=2;i<n;i++)
            {
                if (n % i == 0)
                {
                    b = false;
                    break;
                }

            }
            if(b)
                Console.WriteLine("prime number");
            else
                Console.WriteLine("Not Prime");
        }
        public static void fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial=" + fact);
        }


    }
    public delegate void dlmuli(int n);
    public delegate float deladd(float a, float b);//mostly we delcare delegate outside the class...beacuase we acces them easily without using class name.
    class D2
    {
        static void Main(string[] args)
        {
            deladd d = Delegate2.add;
            float f = d(12.2f, 45.3f);
            Console.WriteLine(f);
            dlmuli s = Delegate2.prime;
            s = s + Delegate2.fact;//here we add two method in one delgate,is called multicast.here we add one or more method.
            s(5);
        }
    }
}
