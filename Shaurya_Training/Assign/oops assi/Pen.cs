using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign
{
    class Pen
    {
        Refil r;
        int caplength;
        string brand;

        public int Caplength { get => caplength; set => caplength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Refil R { get => r; set => r = value; }
    }
    class Refil
    {
        string inkcolor;
        int length;
        Nib n;

        public string Inkcolor { get => inkcolor; set => inkcolor = value; }
        public int Length { get => length; set => length = value; }
        internal Nib N { get => n; set => n = value; }
    }
    class Nib
    {
        string material_type;
        int width;

        public string Material_type { get => material_type; set => material_type = value; }
        public int Width { get => width; set => width = value; }
    }
    class Ls
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.R = new Refil();
           p. R.N = new Nib();
            p.Brand = "cello";
            p.Caplength= 10;
            p.R.Inkcolor = "blue";
            p.R.Length = 5;
            p.R.N.Material_type = "glass";
            p.R.N.Width = 1;
            Console.WriteLine($"pen brand={p.Brand} caplength={p.Caplength}Inkcolor={p.R.Inkcolor}Length={p.R.Length}material type={p.R.N.Material_type}width={p.R.N.Width}");


        }
    }
}
