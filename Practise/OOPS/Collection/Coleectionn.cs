using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPS.Collection
{
    class Coleectionn
        //collecton are growable.
        //generic-
        //list,dictionary,stackquene,sortedlist,linkedlist,hashset
        //non generic.-differnt type of data.(heterogenous)....Ststem.collecton
        //arraylist,hashtable,stack,quene
        //
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();//duplicate are allowed



            Hashtable hs = new Hashtable();//key and value,data stored on hash mehod,duplicate keys not allowed.(key,value)
            /*its use array to store data.but storing data inside array is using hashing technique.
              * ex.hs.add("sanket",90);
              * ex.hs.add("samar",91);
              * here it doing autoboxing means converting primitive data in to refenence.
              * then its generate hascode and doing module of that code and stored into aray.

              *to print indiviual consle.writeline(hs["gauri"]);
              *ht["samar"]="92";//for update value.you never change key.


            emp e1=new emp(1,"a");
            emp e1=new emp(2,"b");
            emp e1=new emp(3,"c");
            object-for every create using new hashcode generated is diffenret
            string ,int=gethascode override.




              */

            hs.Add(10, "ten");
            hs.Add(11, "oen");
            hs.Add(12, "len");
            hs.Add(13, "wen");
            hs.Add(14, "men");
            hs.Add(15, "fen");
            hs.Add(16, "sen");
            foreach(object k in hs.Keys)
            {
                int data = (int)k;
                if(data%2==0)
                Console.WriteLine(k+" "+hs[k]);
            }
            foreach(DictionaryEntry e in hs )
            {
                Console.WriteLine(e.Key+" "+e.Value);
            }
            Hashtable ht = new Hashtable();
            ht.Add("Haphij",30);
            ht.Add("Suraj",30);
            ht.Add("hemnt",30);
            foreach(object k in ht.Keys)
            {
                string s = (string)k;//this is for making operaton
                Console.WriteLine(s.ToLower());
                Console.WriteLine(k+" "+ht[k]);
            }
            foreach(dynamic f in ht.Keys)
            {
                Console.WriteLine(f.ToLower());
            }
        }
    }
}
