using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    abstract class Teacher
    {
        int tid;
        string tname;
        long moblieno;
        private object mobileno;

        public Teacher(int tid, string tname, long moblieno)
        {
            this.tid = tid;
            this.tname = tname;
            this.moblieno = moblieno;
        }

       

        public abstract void Salary();
    }
    class HourlyBased : Teacher
    {
        int rate_per_hrs;
        int hrs;

        public HourlyBased(int tid, string tname, long moblieno, int rate_per_hrs, int hrs):base(tid,tname,moblieno)
        {
            this.rate_per_hrs = rate_per_hrs;
            this.hrs = hrs;
        }


        public override void Salary()
        {
            Console.WriteLine("Enter rate hour");
            rate_per_hrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many hour");
            hrs = int.Parse(Console.ReadLine());
        }
    }
    class SalaryBased : Teacher
    {
        int salary;
        public SalaryBased(int tid, string tname, long moblieno,int salary):base(tid,tname,moblieno)
        {
            this.salary = salary;
        }
        public override void Salary()
        {
            Console.WriteLine(salary);
        }
    }
    class Uti
    {
        static void Main(string[] args)
        {
           Teacher t = new HourlyBased(1,"suraj",9096342541,10,5);
            Teacher t1 = new SalaryBased(2,"ajit",54714542,30000);
        }
    }
}
