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

        public string GetBalance(string pin)
        {
            if (CheckPIN(pin))
            {
                return this.balance.ToString();
            } 
            else
            {
                return "ACCOUNT_ERR";
            }
        }

        public string WithDrawFunds(int amount, string pin)
        {
            if (CheckPIN(pin))
            {
                if (amount > balance + overdraftLimit)
                {
                    return "FUNDS_ERR";
                }
                else
                {
                    balance -= amount;
                    return balance.ToString();
                }
            }
            else
            {
                return "ACCOUNT_ERR";
            }

        }

        public bool CheckPIN(string pin)
        {
            return this.pin == pin;
        }
    }
}
