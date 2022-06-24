using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class Overiddenexception
    {
        public virtual void add()
        {

        }
    }
    class child:Overiddenexception
    {
        public override void add()
        {
            try
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }
}
