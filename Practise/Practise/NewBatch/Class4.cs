using System;
using System.Collections.Generic;
using System.Text;

namespace Practise.NewBatch
{
    class Bank
    {
        int wamt, balance, camt;
        public Bank()
        {
            balance = 25000;
        }
        public void credit()
        {
            Console.WriteLine("enter the amount you want to credit");
            camt = int.Parse(Console.ReadLine());
            balance = balance + camt;

        }
        public void debit()
        {
            Console.WriteLine("Enter amount you want to witdraw");
            wamt = int.Parse(Console.ReadLine());
            if (wamt <= balance)
            {
                Console.WriteLine("succefully withdraw");

                balance = balance - wamt;
            }
            else
                Console.WriteLine("you have insuffient funds");



        }
    }
        class MM
        {
            static void Main(string[] args)
            {
                Bank b = new Bank();
                b.credit();
                b.debit();
            }
        }
    public delegate void Mydel();
    class Bank1
    {
        public event Mydel balIszero;
        public event Mydel insufficientbal;
        int bal;
        public Bank1()
        {
            bal = 0;
        }
        public void credit(int n)
        {
            bal = bal + n;
        }
        public void debit(int n)
        {
            if(bal<n)
            {
                insufficientbal();
            }
            else if(bal>=n)
            {
                bal = bal - n;
                if(bal==0)
                {
                    balIszero();
                }
            }
        }
    }
    class Bank2
    {
        
    }
    
}
