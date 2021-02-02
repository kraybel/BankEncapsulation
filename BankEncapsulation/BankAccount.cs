using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double balance = 0.0;
        

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"A deposit of ${amount.ToString("0.00")} has been added to your account. Thank you.");
        }
        public double GetBalance()
        {
            Console.WriteLine($"Your current account balance is ${balance.ToString("0.00")}.");
            return balance;
        }
    }
}
