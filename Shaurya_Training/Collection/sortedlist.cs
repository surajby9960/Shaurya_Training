using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shaurya_Training.Collection
{
    class student1:IComparable<student1>
    {
        int id;
        string name;

        public student1(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int CompareTo(student1 o)
        {
            return (this.name.CompareTo (o.name));
        }
        public override string ToString()
        {
            return $"id={id}name={name}";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
   
    class Class1
    {
        static void Main(string[] args)
        {
            SortedList<student1, string> st = new SortedList<student1, string>();
            st.Add(new student1(1, "suraj"), "pune");
            st.Add(new student1(2, "amit"), "pune");
            st.Add(new student1(3, "garav"), "pune");
            st.Add(new student1(4, "raj"), "pune");

            foreach (KeyValuePair<student1, string> kv in st)
            {
                Console.WriteLine(kv.Key + " =" + kv.Value);
            }
          
        }
    }
}
