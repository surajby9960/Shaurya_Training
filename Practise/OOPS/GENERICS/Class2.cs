using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOPS.GENERICS
{
    public class Student:IComparable<Student>
    {
        string sname;
        int per;
        public Student(string sname,int per)
        {
            this.Sname = sname;
            this.Per = per;

        }

        public string Sname { get => sname; set => sname = value; }
        public int Per { get => per; set => per = value; }

        public int CompareTo(Student s2)
        {
            return Sname.CompareTo(s2.Sname);
        }
    }
   /* class sortbyper:IComparer<Student>
    {
        public int Comparer(Student x,Student y)
        {
            return x.Per.CompareTo(y.Per); 
        }
    }*/
    class M
    {
        static void Main(string[] args)
        {
            SortedList<Student, string> sl = new SortedList<Student, string>();
            sl.Add(new Student("suraj", 93), "prorigo");
            sl.Add(new Student("ajay", 94), "ibm");
            sl.Add(new Student("varsha", 90), "hm");
            foreach(KeyValuePair<Student,string>kvp in sl )
            {
                Console.WriteLine(kvp.Key+" "+kvp.Value);
            }
        }
    }
}
