using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Acct1 = new BankAccount();
            bool doMore = true;
            do
            {
                Console.Write("For a deposit please enter the amount otherwise type \"balance\" for your current account balance. ");
                var ans1 = Console.ReadLine();
                ans1 = ans1.ToLower();
                if (ans1 == "balance")
                {
                    Acct1.GetBalance();
                }
                else
                {
                    double dep = double.Parse(ans1);
                    Acct1.Deposit(dep);

                }
                Console.Write("Would you like to make another transaction? ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "yes")
                {
                    doMore = true;
                }
                else
                {
                    doMore = false;
                }
            }
            while (doMore == true);
            Console.WriteLine("Thank you. Have a great day.");
        }
    }
}
