using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class Person
    {
        int id;
        string name;
        Vechile v;

        public Person(int id, string name, Vechile v)
        {
            this.id = id;
            this.name = name;
            this.v = v;
        }
        public void display()
        {
            Console.WriteLine($"Id={this.id} Name{this.name} Vechile{v}");
        }
       
    }
    class Vechile
    {
        int vid;
        string vname;

        public Vechile(int vid, string vname)
        {
            this.vid = vid;
            this.vname = vname;
        }
        public override string ToString()
        {
            return $"vechile_id={vid} vechile name={vname}";
        }
    }
    class Fina
    {
        static void Main(string[] args)
        {


          
            Person p = new Person(1, "suraj", new Vechile(2, "tata"));
            Person p1 = new Person(2, "ajit", new Vechile(3, "Mahindra"));
            p.display();
            
        }
    }
}
