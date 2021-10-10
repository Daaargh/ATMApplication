﻿using System;
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
            return balance;
        }

        public string WithDrawFunds(int amount)
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

        public bool CheckPIN(string pin)
        {
            return this.pin == pin;
        }
    }
}
