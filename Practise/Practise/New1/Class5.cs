using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using System.Collections;

namespace Practise.New1
{
    class Student:IComparable
    {
        string sname;
        int per;
        string addr;

        public Student(string sname, int per, string addr)
        {
            this.Sname = sname;
            this.Per = per;
            this.Addr = addr;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Per { get => per; set => per = value; }
        public string Addr { get => addr; set => addr = value; }

        public override string ToString()
        {
            return $"Name={sname}per={per}address={addr}";

        }
        public int CompareTo(Object o)
        {
            Student s2 = (Student)o;
            return per.CompareTo(s2.per);

        }
    }
    class Aa
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(new Student("suraj", 68, "pune"), "java");
            s.Add(new Student("vishal", 78, "Nashik"), "java");
            s.Add(new Student("Ajit", 95, "Mumbai"), "Html");
            s.Add(new Student("Rushi", 50, "pune"), "C++");
            foreach(DictionaryEntry d in s )
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}
