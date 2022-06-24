using System;
using System.Collections.Generic;

namespace Shaurya_Training
{
   class prac
    {
        static void Main(string[] args)
        {

            List<int> li = new List<int>();
            li.Add(10);
            li.Add(10);
            li.Add(30);
            li.Add(10);
            li.Add(20);
            li.Add(10);

            int k = 0;
            foreach (int d in li)
            {
                k++;
                for (int i = k; i < li.Count; i++)
                {
                    if (d == li[i])
                    {
                        li.Remove(li[i]);
                    }
                }
            }
        }
    }
   
}
