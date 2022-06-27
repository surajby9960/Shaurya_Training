using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.Collection_assign
{
    class Colle2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("suraj");
            al.Add("vikas");
            al.Add("ramesh");
            al.Add("siya");
            al.Add("piya");

            al.Sort();
            foreach (string dt in al)
            {
                Console.WriteLine(dt);
            }
            Console.WriteLine("------------------------------");

            int j = al.Count-1;
           
            for (int i = 0; i < al.Count/2; i++) 
            {
                string temp =(string)(al[i]);
                al[i] = al[j];
                al[j] = temp;
                j--;

            }
            foreach (string dt in al)
            {
                Console.WriteLine(dt);
            }



        }
    }
}
