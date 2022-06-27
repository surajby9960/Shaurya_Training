using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPS.Collection
{
    class SortedList1 : IComparable
    {
        string sname;
        int per;
        string city;

        public SortedList1(string sname, int per, string city)
        {
            this.Sname = sname;
            this.Per = per;
            this.City = city;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Per { get => per; set => per = value; }
        public string City { get => city; set => city = value; }

        public int CompareTo(Object o)
        {
            SortedList1 s2 = (SortedList1)o;
            return per.CompareTo(s2.per);

        }
        public override string ToString()
        {
            return $"Name={sname}per={per}city={city}";
        }
    }
    class mysort:IComparer
    {
        public int Compare(Object o1,Object o2)
        {
            StringBuilder s1 = (StringBuilder)o1;
            StringBuilder s2 = (StringBuilder)o2;
            return s1.ToString().CompareTo(s2.ToString());
        }

    }
    class A
    { 
        static void Main(string[] args)
        {
            SortedList ss = new SortedList();
            ss.Add(new SortedList1("suraj", 98, "nagar"),"java");
            ss.Add(new SortedList1("manali", 88, "pune"),"java");
            ss.Add(new SortedList1("varsha", 90, "aurangabad"),"c#");
            ss.Add(new SortedList1("rathin", 86, "nanded"),"html");
            
            foreach (DictionaryEntry d in ss)
            {
                Console.WriteLine(d.Key+" "+d.Value);

            }
            ArrayList a = new ArrayList();
            a.Add(new StringBuilder("amar"));
            a.Add(new StringBuilder("amar"));
            a.Add(new StringBuilder("amar"));
            a.Add(new StringBuilder("amar"));
            a.Sort(new mysort());
            foreach(dynamic x in a)
            {

            }

            
        }
    }
}
