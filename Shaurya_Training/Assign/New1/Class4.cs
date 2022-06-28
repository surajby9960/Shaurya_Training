using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.Assign.New1
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

        public Quetion(string questionn, string option_a, string option_b, string option_c, string option_d, string correct_option)
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
            Java1.Add(new Quetion("who inventd java program?", "guildo vann rossum", "james gosling", "denis ritchie", "bjrane strotups", "b"));
            Java1.Add(new Quetion("which one of following is not java feature?", "Object oriented", "use of pointers", "portable", "dynmic and extensible", "b"));
            Java1.Add(new Quetion("which comonent is use to compile,debug and excute the peogram?", "JRE", "JIT", "JDK", "JVM", "c"));
            Java1.Add(new Quetion("which of this cannot used for varible name is java?", "idenifier&keyword", "identifier", "keyword", "none of the mentioned", "c"));
            Java1.Add(new Quetion("what is the extensiion of java code file?", ".js", ".txt", ".class", ".java", "d"));
            Java1.Add(new Quetion("which enviorment varible is used to set java path?", "maven_path", "javapath", "java", "java_home", "d"));
            Java1.Add(new Quetion("which of the following is not a oops concept in java?", "polymorphism", "inheritance", "compliaton", "encapsulation", "c"));
            Java1.Add(new Quetion("what is the extensiion of compiled java classes?", ".txt", ".js", ".class", ".java", "c"));
            Java1.Add(new Quetion("which exception is thrown when java is out of memory?", "memory error", "outofmemoryerror", "memoryoutofboundexceptio", "memoryfulexception", "b"));
            Java1.Add(new Quetion("which of these selection statement in java?", "break", "continue", "for", "if()", "d"));

            //csharp quiz
            Csharp1.Add(new Quetion("CLR is the .NET equivalant of______", "java virtual machine", "common langauage runtime", "common type system", "common language specification", "a"));
            Csharp1.Add(new Quetion("in c# subroutine is called a________?", "function", "metadata", "method", "manage code", "c"));
            Csharp1.Add(new Quetion("All c# application begin excecuation by calling the______method?", "main", "class", "function", "namespace", "a"));
            Csharp1.Add(new Quetion("A_____is an identifier that denotes  storage location", "constant ", "reference type", "varible", "object", "c"));
            Csharp1.Add(new Quetion("_______are reserved and cannot used as identifiers", "keyword", "literals", "varible", "identifiers", "a"));
            Csharp1.Add(new Quetion("Array in c# are______Object", "reference", "logical", "value", "Aruthmetic", "a"));
            Csharp1.Add(new Quetion("_________varible are visible only in block they are declared", "system", "global", "local", "console", "c"));
            Csharp1.Add(new Quetion("struct data member are________ by default", "protected", "public", "private", "default", "c"));
            Csharp1.Add(new Quetion("Inheritance is ______in nature", "commumtative", "assositaive", "transitive", "Itrative", "c"));
            Csharp1.Add(new Quetion("the reason c# does not support mutiple inheritance is because of_____", "name collison", "method collison", "function coliision", "interface collison", "a"));
            //html quiz
            HTML1.Add(new Quetion("which of the following is used to read an HTML page and render it?", "web servr", "web network", "web browser", "web matrix", "c"));
            HTML1.Add(new Quetion("which of the following yag is for inserting argest heading inHTML?", "large", "<h1>", "<h6>", "heading", "b"));
            HTML1.Add(new Quetion("in which part of HTML metadata contain", "head tag", "title tag", "body tag", "html tag", "a"));
            HTML1.Add(new Quetion("in which element is  used to get highlighted text in HTML?", "<track>", "<mark>", "<highlight>", "<b>", "b"));
            HTML1.Add(new Quetion("which of the following is not HTML tag?", "<track>", "<video>", "<source>", "<slider>", "d"));
            HTML1.Add(new Quetion("how do we write comment in HTML", "</....>", "<!...>", "</.../>", "<../>", "b"));
            HTML1.Add(new Quetion("which of the following is not the element assiciated with the HTML table layout?", "color", "size", "alignment", "spanning", "a"));
            HTML1.Add(new Quetion("which element is use for styling HTML layout?", "js", "jQuery", "css", "php", "c"));
            HTML1.Add(new Quetion("HTML is subset of?", "SGMT", "SGML", "SGME", "XHTML", "b"));
            HTML1.Add(new Quetion("which charcter is used to represent when tag is closed in HTML?", "!", "@", "h", "/", "d"));

        }

        static internal List<Quetion> Java1 { get => Java; set => Java = value; }
        static internal List<Quetion> Csharp1 { get => Csharp; set => Csharp = value; }
        static internal List<Quetion> HTML1 { get => HTML; set => HTML = value; }

        public static void addQ(string q, string a, string b, string c, string d, string corret, string lang)
        {
            if (lang == "java")
                Java1.Add(new Quetion(q, a, b, c, d, corret));
            else if (lang == "csharp")
                Csharp1.Add(new Quetion(q, a, b, c, d, corret));
            else if (lang == "html")
                HTML1.Add(new Quetion(q, a, b, c, d, corret));
        }
    }
        class Logic
        {
            static int javas = 0;
            static int csharps = 0;
            static int htmls = 0;
            public void displyquestion(List<Quetion> arr, int c)
            {
                int score = 0;
                int a = 0;
               Console.WriteLine(arr.Count);
                foreach (Quetion t in arr)
                {
                    a++;
                    Console.WriteLine(a + "." + t.Questionn);
                    Console.WriteLine("a." + t.Option_a);
                    Console.WriteLine("b." + t.Option_b);
                    Console.WriteLine("c." + t.Option_c);
                    Console.WriteLine("d." + t.Option_d);
                    Console.WriteLine("select correct ans:");
                    string ans = (Console.ReadLine());
                    if (ans == t.Correct_option)
                    {
                        score++;

                    }

                }
                Console.WriteLine("your score is=" + score);
                if (c == 1)

                    javas = score;
                else if (c == 2)
                    csharps = score;
                else if (c == 3)
                    htmls = score;



                Console.WriteLine("do you want to play again \ny\nn");
                char r = char.Parse(Console.ReadLine());
                if (r == 'y')
                {
                    repeat();

                }
                else if (r == 'n')
                {
                    Console.WriteLine("java score=" + javas);
                    Console.WriteLine("csharp score=" + csharps);
                    Console.WriteLine("html score=" + htmls);


                }
            }
            public static void repeat()
            {

                Console.WriteLine("which language quiz you want to play:\n1.java\n2.csharp\n3.html");
                int ch = int.Parse(Console.ReadLine());
                Logic lg = new Logic();

                if (ch == 1)
                {
                    lg.displyquestion(Quiz.Java1, ch);

                }


                else if (ch == 2)
                {
                    lg.displyquestion(Quiz.Csharp1, ch);
                }


                else if (ch == 3)
                {
                    lg.displyquestion(Quiz.HTML1, ch);

                }

            }
            public static void aque()
            {
                char c = 'y';
                while (c == 'y')
                {
                    
                      
                        Console.WriteLine("write your question:");
                        string que = Console.ReadLine();
                        Console.WriteLine("enter option a:");
                        string opa = Console.ReadLine();
                        Console.WriteLine("enter option b:");
                        string opb = Console.ReadLine();
                        Console.WriteLine("enter option c:");
                        string opc = Console.ReadLine();
                        Console.WriteLine("enter option d:");
                        string opd = Console.ReadLine();
                        Console.WriteLine("enter option of corect answer:");
                        string ca = Console.ReadLine();
                        Quiz.addQ(que, opa, opb, opc, opd, ca, aq);
                        Console.WriteLine("do you want add more questin\ny\nn");
                        c = char.Parse(Console.ReadLine());

                    
                }
                if(aq=="java")
                {
                    foreach(Quetion d in Quiz.Java1)
                    {
                      Console.WriteLine(d.Questionn);
                    }
                }else if(aq=="csharp")
                {
                  foreach(Quetion d in Quiz.Java1)
                  {
                    Console.WriteLine(d.Questionn);
                  }
                }
                else if (aq == "html")
                {
                   foreach (Quetion d in Quiz.Java1)
                   {
                      Console.WriteLine(d.Questionn);
                   }
                }
            }




           static string aq;
            static void Main(string[] args)
            {
                 Quiz q = new Quiz();
                bool s = true;
                Console.WriteLine("Enter your name:");
                string nm = Console.ReadLine();
                Console.WriteLine("Login as\n1.User\n2.Admin");
                int l = int.Parse(Console.ReadLine());
                if (l == 1)
                {
                    while (s == true)
                    {
                        Console.WriteLine("please enter username:");
                        string un = Console.ReadLine();
                        Console.WriteLine("enter your password:");
                        string pwd = Console.ReadLine();



                        if (un == "admin" && pwd == "root")
                        {
                            Console.WriteLine("you login succesfully!!!");
                            s = false;
                            repeat();
                        }
                        else
                            Console.WriteLine("you enter wrong detail...");

                    }
                }
                else if (l == 2)
                {
                    
                    Console.WriteLine("enter langauge name you want to add Question\njava\nhtml\ncsharp");
                     aq = Console.ReadLine();
                    if (aq == "java")
                    {
                        Logic.aque();
                    }
                }





            }





        }
    
}
