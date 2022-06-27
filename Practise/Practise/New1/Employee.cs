/*using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.New1
{
    class Employee
    {
        int id;
        string name;
        float sal;

        public Employee(int id, string name, float sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Sal { get => sal; set => sal = value; }


       
    }
    class Student
    {
        string name;


        public Student(string name)
        {
            this.Name = name;

        }

        public string Name { get => name; set => name = value; }
    }
    class Course
    {
      //  Student[] s = new Student();
    }
    class MM
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5]
            {
                new Employee(1,"suraj yadav",40541.2f),
                new Employee(1,"suraj",21541.2f),
                new Employee(1,"suraj",21541.2f),
                new Employee(1,"ajit bombe",45541.2f),
                new Employee(1,"suraj",21541.2f)
            };
            for(int i=0;i<emp.Length;i++)
            {
                if(emp[i].Sal>40000)
                {
                    Console.WriteLine(emp[i].Name);
                }
            }
            Csharp[] cs = new Csharp[10]
            {
               new Csharp ("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp("suraj","c#"),
               new Csharp ("suraj","c#"),
               new Csharp("suraj","c#"),
            };
            for(int i=0;i<cs.Length;i++)
            {
                Console.WriteLine(cs[i].Name+" "+cs[i].Course);
            }
                
            
        }
    }
}*/
