using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Student
    {
        string name;
        int p;

        public Student(string nm, int per)
        {
            name = nm;
            p = per;
           // Console.WriteLine(name+" "+p);
        }

        static void Main(string[] args)
        {
            Student[] sarr = new Student[2];
            string nm;
            int per;
            for(int i=0;i<sarr.Length;i++)
            {
                Console.WriteLine("enter name per");
                nm = Console.ReadLine();
                per = int.Parse(Console.ReadLine());
                sarr[i] = new Student(nm, per);
            }
            for (int i=0;i<sarr.Length;i++)
            {
                Console.WriteLine(sarr[i].name);
            }
           
        }
    }
}
