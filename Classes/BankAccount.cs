using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplication.Classes
{
    public class BankAccount
    {
        string accountNumber;
        string pin;
        int balance;
        int overdraftLimit;
        int balanceLimit;

        public BankAccount(string accountNumber, string pin, int balance, int overdraftLimit)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = balance;
            this.overdraftLimit = overdraftLimit;
            this.balanceLimit = overdraftLimit * (-1);
        }

        public int GetBalance()
        {
            Console.WriteLine(balance);
            return this.balance;
        }

        public void WithDrawFunds(int amount)
        {
            if (balance < balanceLimit)
            {
                Console.WriteLine("FUNDS_ERR");
            }
            else
            {
                balance -= amount;
                Console.WriteLine(balance);
            }
        }

        public bool CheckPIN(string pin)
        {
            return this.pin == pin;
        }
    }
}
