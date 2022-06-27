using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.New1
{
    class Class2
    {
        static void Main(string[] args)
        {
            string str = "i 1live in3 maha8rash4tra";
            string[] s = str.Split(" ");
            int max = 0;
            string longest = "";
            for(int i=0;i<s.Length;i++)
            {
               if( s[i].Length > max)
                {
                   longest = s[i];
                }
                
            }
            Console.WriteLine(longest);
            //---------vowel in string------
            char[] s2 = str.ToCharArray();
            int cntv = 0;
            for(int i=0;i<s2.Length;i++)
            
            {
                if(s2[i]=='a'|| s2[i] == 'e' || s2[i] == 'i' || s2[i] == 'o' || s2[i] == 'u')
                {
                    cntv++;
                }

            }
            Console.WriteLine("no of vowel="+cntv);
            //------------average of digit present in string----
            int sum = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                bool isp = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (s2[i] == s2[k])
                    {
                        isp = true;
                        break;
                    }
                }
                   if (isp==false)
                    for (int j = i; j < s2.Length; j++)
                    {
                        if (s2[i] == s2[j])
                        {
                            
                        }
                    }
           
            }   
                Console.WriteLine(sum);
        }
    }
}
