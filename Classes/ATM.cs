using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplication.Classes
{
    public class ATM
    {
        int initialBalance;
        BankAccount account;

        public ATM(int initialBalance, BankAccount account)
        {
            this.initialBalance = initialBalance;
            this.account = account;
        }

        public string WithdrawMoney(int amount, string pin)
        {
            if (initialBalance == 0)
            {
                return "ATM_ERR";
            }
            else if ((initialBalance - amount) < 0)
            {
                return "FUNDS_ERR";
            }
            else
            {
                return account.WithDrawFunds(amount, pin);
            }
        }

        public string CheckAccountBalance(string pin)
        {
            return account.GetBalance(pin);
        }

        public string GetBalance()
        {
            return initialBalance.ToString();
        }
    }
}
