using System;
using System.Collections.Generic;

namespace Shaurya_Training
{
    class stude
    {
        int sid;
        string sname;
        string addr;

        public stude(int sid, string sname, string addr)
        {
            this.Sid = sid;
            this.Sname = sname;
            this.Addr = addr;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Addr { get => addr; set => addr = value; }
        static void Main(string[] args)
        {
            Dictionary<stude, int> dc = new Dictionary<stude, int>();
            dc.Add(new stude(1, "suraj", "pune"), 411018);
            dc.Add(new stude(2, "raj", "pimpri"), 471018);
            dc.Add(new stude(3, "sunil", "nagar"), 411017);

            foreach (KeyValuePair<stude, int> kv in dc)
            {
                Console.WriteLine(kv.Key+"=>"+kv.Value);
            }
           
        }
        
        public override bool Equals(object obj)
        {
            return obj is stude stude &&
                   sid == stude.sid;
                  // sname == stude.sname &&
                  // addr == stude.addr;
        }

        public override int GetHashCode()
        {
            return sid;
        }
        public override string ToString()
        {
            return $"{sid}   {sname}    { addr}";
        }
       
    }
   
}
