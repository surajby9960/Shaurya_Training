using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.NewBatch
{
    class Department
    {
       // int dept_id;
       string dept_name,location;//this varible also knows as Data member
        public Department()
        {
                
        }

        public Department(string dept_name,string location)//ctor for creating cnstructor.
        {
            //this is refer to data memeber.
            this.dept_name = dept_name;
            this.location = location;
        }

       // public int Dept_id { get => dept_id; set => dept_id = value; }
        public string Dept_name { get => dept_name; set => dept_name = value; }//with varible.
        public int Dept_id { get; set; }//without varible.


        

        public override string ToString()
        {
            return $"name={Dept_name}did={Dept_id}";
        }
        
        static void Main(string[] args)
        {
            //properties intitilizer
            Department dp = new Department();
            dp.Dept_id = 20;
            dp.Dept_name = "Computer";
            
            Console.WriteLine("dept id="+dp.Dept_id);
            Console.WriteLine("dname="+dp.Dept_name);

            //object intitilizer.
            Department d2 = new Department { Dept_id = 12, dept_name = "hr" };
            Console.WriteLine(d2);//implicicity call
            Console.WriteLine(d2.ToString());//explicitly call

            Department d3 = new Department("cs", "pune");//here we cant change the sequence.
            //name argument.
            Department d4 = new Department(dept_name: "ha", location: "nashik");//here change the sequence.



            Emp e = new Emp("suraj", 20111);
            Emp e1 = new Emp("suraj", 20111);
            Emp e2 = new Emp("suraj", 20111);
            Emp e3 = new Emp("suraj", 20111);
            Console.WriteLine(e);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            
            
        }
        class Emp
        {
            static int count;
            int id;
            string name;
            double sal;
            public Emp(string name,double sal)
            {
                count++;
                id = count;
                this.name = name;
                this.sal = sal;
                
            }
            public override string ToString()
            {
                return $"id{id}Name{name}Salary{sal}";
            }


        }
    }
}
