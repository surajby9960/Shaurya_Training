using System;

namespace OOPS
{
    class Student//class is default internal.
    {
        int sid;//instace varbile are default private.
      string name;//instace varible;
       protected float per;//protected are only accesible in child class object.
        public void Add()//this is method.method bydefault is private.
        {
            int a = 10, b = 20;//local varible.
            Console.WriteLine(  a+b);
            
        }
        public Student(int i,string nm,float p)//this is parametrized  constrctor.
        {

        }
        public Student()//ths is default constructor,defualt contrucor is automaticaly created when user not create any parametrized contructor.
        {

        }

    }
    class STest:Student//Stest is child class of Student base class..
    {
        
        static void Main(string[] args)//main method...entry point of programe..
        {
           STest s = new STest();//this is process of making object of class.
            
            
            
            

            
        }
    }
}

