using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Shaurya_Training.Collection
{
    class Student1
    {
        int sid;
        string name;
        int per;

        public Student1(int sid, string name, int per)
        {
            this.Sid = sid;
            this.Name = name;
            this.Per = per;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Per { get => per; set => per = value; }

        public override bool Equals(object obj)// this is reqire to check key is same or not..on object basis we cant recognize.
        {
            return obj is Student1 student &&
                   sid == student.sid &&
                   name == student.name &&
                   per == student.per;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sid, name, per);
        }
    }
    class Dictonary1
    {

        /*
         key alwys be unique and cant be null.
        for data retrive yu need key.
        key is never replace only vlue replace  key remain same.
        it is used hashing tecnique to store data,and EQUALS METHOD
        its calculate hashcode of key,return type of hashcode metod is int.

         
         */
        static void Main(string[] args)
        {
            //generic
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(1, "suraj");
            d1.Add(2, "prati");
            d1.Add(3, "shivani");
            Console.WriteLine(d1[1]);  //to get value only pass key.
            d1[1] = "ajay";// t change particular value .
            d1.Remove(2);
            // to print all ddata
            d1.ContainsKey(2);//o check key is present or not.


            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }

            // non generic
            Hashtable ht = new Hashtable();///here stored mixture type of data.
            // ant type of key and value allow here.
            ht.Add(10, 12);
            ht.Add(10, "sutah");
            ht.Add("sutah", 21);

            Dictionary<Student1, string> di = new Dictionary<Student1, string>();
            di.Add(new Student1(1, "suraj", 65), "pune");//in that type hascode is diff thats why we use hascode ans equals method.
            di.Add(new Student1(1, "suraj", 65), "pune");
            foreach (KeyValuePair<Student1,string> kv in di)
            {
                Console.WriteLine(kv.Key+"=>"+kv.Value);
            }

        }
    }

      
}
