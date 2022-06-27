using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.GENERICS
{
    class Class1
    {

        static void Main(string[] args)
        {
            List<string> ls = new List<string>();//generic is used to store particular type of data.
            ls.Add("suraj");
            ls.Add("mahesh");//here only allowed tring type date,because we deine list as string.
            //ls.Add(10);   here you try to add int type of data its giving error.
            string str = ls[1];//we get date directly like this,without cnversion.
            Console.WriteLine(str);

            string[] arr = { "A", "b", "c" };
            List<string> ls1 = new List<string>() { "om", "ram", "shiva" };
            Stack<string> st = new Stack<string>();
            st.Push("geet");
            st.Push("preet");
            st.Push("meet");

            ls.AddRange(arr);//here you pass another same type generic collection like array or list you pass.
            ls.AddRange(ls1);//to merge two list into together
            ls.AddRange(st);

            ls.Remove("suraj");//remov
            ls.RemoveAt(2);
            ls.Sort();
            //ls.Reverse();
            ls.Insert(1, "aditya");

            foreach (string d in ls)
            {
                Console.WriteLine(d);
            }
            
        }
        
        
    }
}
