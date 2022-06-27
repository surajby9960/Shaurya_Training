using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Collection
{
    class Duplicate
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("sun");
            arrayList.Add("mon");
            arrayList.Add("tue");
            arrayList.Add("mon"); 
            arrayList.Add("sun");
            arrayList.Add("wed"); 
            arrayList.Add("sat");
            arrayList.Add("fri");
            arrayList.Add("wed");
            for (int i = 0; i < arrayList.Count; i++)
            {
                for (int j = i + 1; j < arrayList.Count; j++)
                {
                    if (arrayList[i].ToString() == arrayList[j].ToString())
                        arrayList.Remove(arrayList[j]);
                }
            }
            foreach (var x in arrayList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
