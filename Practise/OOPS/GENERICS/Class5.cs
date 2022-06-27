using System;
using System.Collections.Generic;
using System.Text;
//colletion Q2
namespace OOPS.GENERICS
{
    class Emp
    {
        string name;
        string designation;
        int salary;
        public Emp(string name, string designation, int salary)
        {
            this.name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }
        public override string ToString()
        {
            return $"name={name}desiganation={designation}salary={salary}";
        }
        
    }
    class MM
    {
        static void Main(string[] args)
        {
            List<object> ls = new List<object>();
            ls.Add(new Emp("suraj", "professor", 90000));
            ls.Add(new Emp("vidya", "wife", 00000));
            ls.Add(new Emp("ajit", "pa", 20000));
            ls.Add(new Emp("sahil", "worker", 54000));
            foreach(var v in ls)
            {
                Console.WriteLine(v);
            }
            Queue<string> clr = new Queue<string>();
            clr.Enqueue("Red");
            clr.Enqueue("yellow");
            clr.Enqueue("green");
            clr.Enqueue("white");
            clr.Enqueue("purple");
            foreach(string cl in clr)
            {
                Console.WriteLine(cl);
            }
        }
    }
}
