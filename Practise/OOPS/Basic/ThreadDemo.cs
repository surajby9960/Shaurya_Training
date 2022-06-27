using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOPS.Basic
{
    class Multithreading
    {
        public void Run()
        {
            Thread t = Thread.CurrentThread;//return the currtnly executaing thread.

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                //Thread.Sleep(2000);//its stop for 2 sec.
            }
        }
    }
    class Programe
    {
        static void Main(string[] args)
        {
            Multithreading m = new Multithreading();
            Thread t1 = new Thread(new ThreadStart(m.Run));
            Thread t2 = new Thread(new ThreadStart(m.Run));
            t1.Name = "t1 thread";
            t2.Name = "t2 thread";
            t1.Start();
            //  t1.Join();
            t2.Start();
            Console.WriteLine("hii");
            //its not aloow ti other thread execuation till his first complted.
        }
    }
}
