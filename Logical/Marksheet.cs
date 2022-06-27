using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.Logical
{
    class Marksheet
    {
        static void Main(string[] args)
        {
            int eng, hindi, marathi, science, history;
            int total,average;
            float percetage;
            Console.WriteLine("Enter eng, hindi, marathi, science, history marks:");
            eng = Convert.ToInt32(Console.ReadLine());
            hindi= Convert.ToInt32(Console.ReadLine());
            marathi = Convert.ToInt32(Console.ReadLine());
            science = Convert.ToInt32(Console.ReadLine());
            history = Convert.ToInt32(Console.ReadLine());
            total = eng + history + hindi + marathi + science;
            Console.WriteLine(total);
            average = total / 5;
            percetage = (float)(100f * (total/500f));
            Console.WriteLine(percetage);
            if (percetage > 90)
            {
                Console.WriteLine("First Class...");
            }
            else if (percetage > 70)
            {
                Console.WriteLine("Second Class...");
            }
            else if(percetage>40)
            {
                Console.WriteLine("Pass");

            }
            else
                Console.WriteLine("Fail!");
            
            
        }
    }
}
