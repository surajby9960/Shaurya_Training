using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Practise.NewBatch
{

    class Prodcut
    {
        int pid;
        string pname;
        int price;

        public int Pid { get => pid; set => pid = value; }
        public string Pname { get => pname; set => pname = value; }
        public int Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"name={pname}pid={pid}price={price}";
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            Prodcut[] p = new Prodcut[4];
            {
                new Prodcut { Pid = 1, Pname = "rubber", Price = 21 };
                new Prodcut { Pid = 1, Pname = "rubber", Price = 21 };
                new Prodcut { Pid = 1, Pname = "rubber", Price = 21 };
            }
            foreach(Prodcut items in p)
            {
                Console.WriteLine(items);
            }

           /* int[,]arr = new int[4, 3];
            int[,] arr2 = new int[,]
                {
                {1,2,3},
                {1,2,3},
                {1,2,3},
            };
            for(int i=0;i<arr2.GetLength(0);i++)
            {
                for(int j=0;j<arr2.GetLength(1);j++)
                {
                    Console.Write(arr2[i,j]);
                }
                Console.WriteLine();
            }
            //another way
            foreach(int d in arr2)
            {
                Console.WriteLine(d);
            }
            

            for(int i=0;i<4;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("enter"+i+" ,"+j+"element");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }*/



            //jagged array
            int[][] jarr = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{1,2},
                new int[]{1,2,4,5,6},
                new int[]{1},
                

            };
            for(int i=0;i<jarr.Length;i++)
            {

                for(int j=0; j<jarr[i].Length;j++)
                {
                    Console.Write(jarr[i][j]);
                }
                Console.WriteLine();
            }
            //dictionary

            Dictionary<int, string> D = new Dictionary<int, string>();
            D.Add(11, "india");
            D.Add(22, "japan");
            D.Add(33, "farnce");
            Console.WriteLine("code| country");
            foreach (KeyValuePair<int, string> s in D)
            {
                Console.WriteLine(s.Key+"  |  "+s.Value);
            }


        }
    }
}
