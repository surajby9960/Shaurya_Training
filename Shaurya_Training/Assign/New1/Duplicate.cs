using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.New1
{
    class Duplicate
    {
        static void Main(string[] args)
        {
            string str = "my name is suraj .my village name is nagar is big city";
            string[] a = { "suraj", "anil", "Pratiksha", "raju" };
            string[] s = str.Split(" ");
            int cnt = 0;

            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i; j < a.Length-1; j++)
                {
                    if (a[i].CompareTo(a[j + 1]) < 1)
                    {
                        string temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            foreach(string aa in a)
            {
                Console.WriteLine(aa);
            }
            for (int i = 0; i < s.Length; i++)
            {
                bool isp = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(s[k]==s[i])

                    {
                        isp = true;
                    }
                }
                if(isp==false)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            cnt++;
                            
                            Console.WriteLine(s[i] + " is present in =" + j + " place");

                        }
                    }
                }
            }

        }
    }
}
