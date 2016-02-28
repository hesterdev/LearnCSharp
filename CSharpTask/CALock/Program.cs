﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CALock
{
    //class Program
    //{
    //    public void RunMe()
    //    {
    //        Console.WriteLine("RunMe called");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program b = new Program();
    //        Thread t = new Thread(b.RunMe);
    //        t.Start();

    //        Console.WriteLine("Done");
    //        Console.ReadKey();
    //    }
    //}

    class Account
    {
        private object thisLock = new object();
        int balance;

        Random r = new Random();
        public Account(int initial)
        {
            balance = initial;
        }

        int Withdraw(int amount)
        {
            //This condition will never be true unless the lock statement
            // is commented out:
            if (balance < 0)
            {
                throw new Exception("Negative Balance");
            }

            //Comment out the next line to see the effect of leaving out the lock keyword:
            lock (thisLock)
            {
                if (balance >= amount)
                {
                    Console.WriteLine("Balance before Withdrawal :  " + balance);
                    Console.WriteLine("Amount to Withdraw        : -" + amount);
                    balance = balance - amount;
                    Console.WriteLine("Balance after Withdrawal  :  " + balance);
                    Console.WriteLine();
                    return amount;
                }
                else
                {
                    return 0;//transaction rejected
                }
            }
        }
        public void DoTransactions()
        {
            for(int i = 0; i < 100; i++)
            {
                Withdraw(r.Next(1, 100));
            }
        }
    }
    class Test
    {
        static  void Main()
        {
            Thread[] threads = new Thread[10];
            Account acc = new Account(1000);
            for(int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                threads[i] = t;
            }
            for(int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
