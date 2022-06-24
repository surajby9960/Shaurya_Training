using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    interface ICake
    {
        abstract void bake();
    }
    class Strawberry:ICake
    {
        public  void bake()
        {
            Console.WriteLine("bake for 20 min");
        }
    }
    class Blackforest:ICake
    {
        public void bake()
        {
            Console.WriteLine("bake for 33 min");
        }
    }
    class Intr
    {
        static void Main(string[] args)
        {
            Strawberry st = new Strawberry();
            st.bake();
            Blackforest bf = new Blackforest();
            bf.bake();
        }
    }
}
