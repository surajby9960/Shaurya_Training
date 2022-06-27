using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections;


/*generic:-       list        dictonary,      sortedList    stack     quene
 * non generic:-  ArrayList   hashtable       sortedList    stack     quene
 */


namespace Shaurya_Training.Collection
{
    //collection
    //Array        both are containers in which store data.
    //collectin only store object..not store value at is.value get conveted in objejt using autoboxing
    class emp
    {
        string name;
        int num;
        public emp(string name,int num)
        {
            this.name = name;
            this.num = num;
        }
        public override string ToString()
        {
            return name + " " + num;
        }
        static void Main(string[] args)
        {
            //autoboxing auto unboxing
            int a = 90;//valued type.
            Object ob = a;//refernce type. this is autoboxing.in this case var a is on heap and addres of that a is stored in ob .ob in stack
            int d = (int)ob;// out unboxing.
            
            ArrayList al = new ArrayList();//growable array.default size is 4.duplicate allowed here.its preseve insertion order.use array to store date in backgroung
            al.Add(90);//to add Add method is here.it add elemnt in last 
            al.Add(100);
            al.Add("suraj");
            al.Add(new emp("om", 123));
            al[0] = 3250;
            al.Remove(100);//to remove data.
            al.Insert(2, 20);// ths add data in between where we pass index
            
            
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }



        //in non generic awyas do casting.
            

        }
    }
    class A
    {
        object obj;
        public object Obj { get => obj; set => obj = value; }
    }
    class T
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Obj = new string("yadav");
        }
    }
    //generic use in real time.it save same data type data.
    class DemoList
    {
        //same as arraylist ,only save same type of data.
      
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>();//here we make student type object list.

            lst.Add(new Student(1, "suraj", 96));
            lst.Add(new Student(2, "ajit", 76));
            lst.Add(new Student(3, "nagesh", 56));
            lst.Add(new Student(4, "sunil", 88));
            foreach(Student data in lst)
            {
                if(data.Per>80)
                {
                    Console.WriteLine(data);
                }
            }
            List<string> ls = new List<string>();
            List<string> ls1 = new List<string>() { "sa", "as" };
            ls.Add("suraj");
            ls.Add("ajit");
            ls.Add("suman");
            ls.Add("varsha");
            ls.Add("vidya");
            ls.AddRange(ls1);// ....is use to add two list.

            //non genric stack.duplicate are also alowed

            Stack st = new Stack();
            st.Push(100);
            st.Push("suraj");
            st.Push(21.5);
            st.Pop();//this method remove last inserted  data and also print data
            st.Peek();//its get only last inserted element.
            foreach(var data in st)
            {
                Console.WriteLine(data);
            }




            //genric stack.duplicate allowed.
            Stack<int> st1 = new Stack<int>();
            st1.Push(10);
            st1.Push(10);
            st1.Push(10);
            foreach(int data in st1)
            {
                Console.WriteLine(data);
            }



            //Quene..non generic
            Queue q = new Queue();
            q.Enqueue(1210);
            q.Enqueue("priya");
            q.Enqueue(new emp("ravi",14));
            q.Enqueue(12);
            Console.WriteLine(q.Dequeue());
            
            foreach(object dt in q)
            {
                Console.WriteLine( dt);
            }

        }
        class Student
        {
            int sid;
            string name;
            int per;

            public Student(int sid, string name, int per)
            {
                this.Sid = sid;
                this.Name = name;
                this.Per = per;
            }
            public override string ToString()   //to show objexct in console we override ToString() method.
            {
                return $"name{name} id{sid}percemtage{per}";
            }
            public int Sid { get => sid; set => sid = value; }
            public string Name { get => name; set => name = value; }
            public int Per { get => per; set => per = value; }
        }
    }
    
}
