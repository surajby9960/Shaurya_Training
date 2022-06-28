using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.funStr
{
    class Paswordcheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter password");
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();
           
            int cnts = 0;
            int cntb = 0;
            int cntsym = 0;
            int cntd = 0;
            if (str.Length <= 5)
            {
                Console.WriteLine("Invaid password");
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] >= 'a' && a[i] <= 'z')
                    {
                        cnts++;
                    }
                    else if (a[i] >= 'A' && a[i] <= 'z')
                    {
                        cntb++;
                    }
                    else if (a[i] >= '0' && a[i] <= '9')
                    {
                        cntd++;
                    }
                    else
                    {
                        cntsym++;
                    }
                }
            }
                if (cnts == 0)
                
                      Console.WriteLine("enter small case charcter");
               else if(cntb==0)
            
                      Console.WriteLine("enter any uppercase char");
            
               else if(cntd==0)
            
                      Console.WriteLine("enter any digit");
            
                else if(cntsym==0)
                       Console.WriteLine("you not engter ay spcl char");

            
            
            

            

        }
    }
}
