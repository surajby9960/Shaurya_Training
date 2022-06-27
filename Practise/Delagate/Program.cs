using System;

namespace Delagate
{
    //delegate hold address/rferences of a method and after excute.
    //it is use to store addres sof method
    class DelegateDemo
    {
        public delegate void mydel(int a, float b);//this delegate define for M1 method,return type of delegate same as method lke vid,int ,string etc.
                                                   //and also parameter should same .here like(int a,int b).
        public static void M1(int a, float b)
        {
            Console.WriteLine($"{a} {b}");
        }
        public delegate int del2(int n);
     public int squre(int n)
        {
            return n * n;
        }
        static void Main(string[] args)
        {
            mydel m = M1;//here we store the address of m1 method in m delgate.
            m(25, 12.2f);//here acces  the metod M1 using delegate m.
            DelegateDemo dd = new DelegateDemo();
            del2 d = dd.squre;
            int ans=d(5);
            Console.WriteLine(ans);
            C.myd v = C.fact1;
            v(4);

        }
    }
    class C
    {
        public delegate void myd(int n);
       public static void fact1(int n)
        {
           int fact = 1;
            for(int i=0;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial="+fact);

        }
    }
}
