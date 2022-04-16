using System;

namespace Delegates
{
    public class Account
    {
        //event money UnderBalance;
        //event money BalanceZero; 
        static int account_number;
        static string customer_name;
        static int balance = 100000;
        public static void withdraw(int a)
        {

            Console.WriteLine("After withdraw Remaining balance={0}", balance - a);
        }
        public static void deposit(int a)
        {

            Console.WriteLine("After Deposit Remaining balance={0}", balance + a);
        }
    }
    class Program
    {
        delegate void Money(int x);

        static void Main(string[] args)
        {
            /*
            ArrayList e1 = new ArrayList()
                {
                    new Account{account_number=10,customer_name="s",balance=1000},
                    new Account{account_number=10,customer_name="sa",balance=2000},
                    new Account{account_number=10,customer_name="sai",balance=13000}, };
                foreach (Account i in e1)
                {
                    Console.WriteLine(i.account_number + " " + i.customer_name);
                }*/


            // Delegate instantiation  
            Money obj = Account.withdraw;
            obj += Account.deposit;

            obj(100);
            obj(1000);

            Console.ReadLine();
        }
    }
}
