using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;// you should import this class.


namespace Shaurya_2.NewFolder
{
    //thrad is path or direction of progrme excuate.
    class Thre1
    {
        public static Thread main;

        public  static void intge()
     {
            main.Join();
            
            Thread tt = Thread.CurrentThread;//here give t1 refernces
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine( i);
                Thread.Sleep(1000);//here t1 goes into sleep;
            }
     }
    /*}
    class MM
    {*/
        static void Main(string[] args)
        {
             main = Thread.CurrentThread;
            Thread tt = Thread.CurrentThread;//its gives references of thread.
            Console.WriteLine("hii");
            Console.WriteLine("suraj");
            Thread t1 = new Thread(Thre1.intge);//creating of thread and apply method.
            t1.Start();
           // t1.Join();//curent excuating thread wait until t1 complte all opertion.
            Thread.Sleep(2000);//here main thread goes in sleep.beacuse here main thread in working.
            for(int i=11;i<21;i++)
            {
                Console.WriteLine(i+"");
            }
            

        }
    }
}
