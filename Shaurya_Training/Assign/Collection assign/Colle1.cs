using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Shaurya_Training.Assign.Collection_assign
{
    class Colle1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("sun");
            al.Add("mon");
            al.Add("fri");
            al.Add("sun");
            al.Add("mon");
            al.Add("fri");
            al.Add("sun");
            al.Add("fri");
            al.Add("sun");
            al.Add("mon");
            ArrayList al1 = new ArrayList();
            
            foreach(string data in al)
            {
                if (al1.Contains(data) == false)
                    al1.Add(data);
            }
            foreach(string dt in al1)
            {
                Console.WriteLine(dt);
            }
        }
    }
}
