using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Basic
{
    struct Theory//for struct its valued type .memory allocated in stack section
    {   //struct cannot have inherited
        //no parametric contrctor allow
        //for small amount of data use struct.
    }
    class cl//its refernce type.its create memory in heap section.
    {
        static void Display(params string[]n)
        {
            foreach(var item in n)
            {
                Console.WriteLine(item);
            }

        }
        static void Main(string[] args)
        {
            Display("user1", "usr2");
            Display("user2");



            string s = "shanaya";
            char[] s1 = new char[s.Length];
            
            for(int i=0;i<s.Length;i++)
            {
                for(int j=0;j<s1.Length;j++)
                {
                    if(s[i]!=s1[j])
                    {
                        s1[j] = s[i];
                    }
                    
                   
                }

            }
            foreach(char d in s1 )
            {
                Console.WriteLine(d);
            }


            /* string st = "  deepa shaha  ";
             string ls = " ";
             char[] c = st.ToCharArray();
             Console.WriteLine(c[2]);
             for (int i = 0; i < c.Length; i++)
             {
                 while(c[i+1]>'a'&&c[i+1]<'z')
                 {
                     i++;
                 }
                 ls = ls + s[i];
             }
             Console.WriteLine(ls);*/

           // --------------------------
           //word form or not.

            Console.WriteLine("enter any word");
            string w = Console.ReadLine();
            char[] a = w.ToCharArray();
            int cnt = 0;
            for(int i = 0; i < a.Length; i++)
            {
               
            }
            for (int i = 0; i < a.Length; i++)
            {
                for(int j=0;j<s.Length;j++)
                {
                    
                    if(a[i]==s[j])
                    {
                        
                         
                        cnt++;
                        break;
                    }
                    
                }
            }
            if(cnt==w.Length)
            {
                Console.WriteLine("possible");
            }
            else
                Console.WriteLine("not possible");
        }

    }
}
