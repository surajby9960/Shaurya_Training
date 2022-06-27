using System;
using System.Collections;
using System.Collections.Generic;

namespace Project
{
    class Quetion
    {
        string questionn;
        string option_a;
        string option_b;
        string option_c;
        string option_d;
        string correct_option;
        public Quetion()
        { }
         
        public Quetion(string questionn,string option_a, string option_b, string option_c, string option_d,string correct_option)
        {
            this.Questionn = questionn;
            this.Option_a = option_a;
            this.Option_b = option_b;
            this.Option_c = option_c;
            this.Option_d = option_d;
            this.Correct_option = correct_option;

        }

        public string Questionn { get => questionn; set => questionn = value; }
        public string Option_a { get => option_a; set => option_a = value; }
        public string Option_b { get => option_b; set => option_b = value; }
        public string Option_c { get => option_c; set => option_c = value; }
        public string Option_d { get => option_d; set => option_d = value; }
        public string Correct_option { get => correct_option; set => correct_option = value; }
    }
    class Quiz
    {
        static List<Quetion> Java = new List<Quetion>();
        static List<Quetion> Csharp = new List<Quetion>();
        static List<Quetion> HTML = new List<Quetion>();
        public Quiz()
        {
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Java.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));

            //csharp quiz
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            Csharp.Add(new Quetion("what is java?", "pl", "nu", "dsf", "jh", "b"));
            //html quiz
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            HTML.Add(new Quetion("html tag", "gh", "yt", "kl", "klo", "c"));
            
        }
    }
    class Logic
    {
       

        static void Main(string[] args)
        {

            Quiz q = new Quiz();
            Console.WriteLine("which language quiz you want to play:/n1.java/n2.csharp/n3.html");
            int ch = int.Parse(Console.ReadLine());
          
            Quetion qn = new Quetion();




        }
    }
}
