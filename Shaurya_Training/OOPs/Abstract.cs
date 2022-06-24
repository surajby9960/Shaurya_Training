using System;
using System.Collections.Generic;
using System.Text;

namespace Shaurya_Training.OOPs
{
   
        abstract class Mobile              //abstract class is contain some incomlte method
        {                                   //incomplte means only declartion no defination
            public void M1()
            {

            }
            abstract public void sms();      //this is abstract method.
                                              //if your class contaion one or more abstarct type then class must be abstract;

        }

        class Samsung : Mobile             //to complte abstrct method we inherited that classs into child.and giv defination that incomlte method.
        {
            public override void sms()       //when you do defination to abstcrt method must write override.
            {
                Console.WriteLine("in samsung sms");
            }
            static void Main(string[] args)
            {
                                                // Mobile m = new Mobile();you never create object of absratct class;
                Mobile m = new Samsung();        //you can give memory of child..is possible.
                m.M1();
                m.sms();
            }
        }

    
}
