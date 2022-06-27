using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class Vol
    {
        double v;
        public void Double_volume(int r)
        {
            Console.WriteLine(v = 4 / 3 * 22 / 7 * r);
        }
        public void Double_volume(double h, double r)
        {
            Console.WriteLine(v = 22 / 7 * r * h);
        }
        public void Double_volume(double l, double b, double h)
        {
            Console.WriteLine(v = l * b * h);
        }
    }
        class Ovel
        {
            static void Main(string[] args)
            {
                Vol v1 = new Vol();
                v1.Double_volume(5);
                v1.Double_volume(5, 7);
                v1.Double_volume(5, 7, 9);
            }
        }
    
}