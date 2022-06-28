using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.New1
{
    class PSST
    {
        string en;
        int score, comp;
        string en2;

        public string En { get => en; set => en = value; }
        public int Score { get => score; set => score = value; }
        public int Comp { get => comp; set => comp = value; }
        public string En2 { get => en2; set => en2 = value; }
       
        public void play(string s)
        {
            
            Random st = new Random();
            int rand_num = st.Next(1, 3);
            if (rand_num == 1)
                En2 = "Rock";
            else if (rand_num == 2)
                En2 = "paper";
            else if (rand_num == 3)
                En2 = "scissor";
            Console.WriteLine("you choose="+En);
            Console.WriteLine("compute choose="+En2);
            display();

            
        }
        public void display()
        {
          
            if (En == "Rock" && En2 == "scissor")
                Score++;
            else if (En == "paper" && En2 == "scissor")
                Comp++;
            else if (En == "scissor" && En2 == "Rock")
                Comp++;

            else if (En == "Rock" && En2 == "paper")
                Comp++;

            else if (En == "paper" && En2 == "Rock")
                Score++;

            else if (En == "scissor" && En2 == "paper")
                Score++;


        }
        
        

        static void Main(string[] args)
        {
            PSST p = new PSST();
            p.score = 0;
           p. comp = 0;
            Console.WriteLine("welcome to game world!!!\n here you play rock paper scissor game. ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("select any one of the following\n1.Rock\n2.scissor\n3.paper");
                int sel = int.Parse(Console.ReadLine());
               
                if (sel == 1)

                    p.En = "Rock";

                else if (sel == 2)
                   p.En = "scissor";
                else if (sel == 3)
                    p.En = "paper";
                p.play(p.En);
            }
            Console.WriteLine("your score is="+p.score);
            Console.WriteLine("Opponent score is="+p.comp);
            if(p.score>p.comp)
                Console.WriteLine("Congraulation you win!!");
            else if(p.score<p.comp)
                Console.WriteLine("you loose");



        }



    }
}
