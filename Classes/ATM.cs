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

        public void WithdrawMoney(int amount, string pin)
        {
            if ((initialBalance - amount) < 0)
            {
                Console.WriteLine("FUNDS_ERR");
            }
            else if (initialBalance == 0)
            {
                Console.WriteLine("ATM_ERR");
            }
            else
            {
                Console.WriteLine(account.WithDrawFunds(amount, pin));
            }

            return;
        }

        public void CheckAccountBalance(string pin)
        {
            Console.WriteLine(account.GetBalance(pin));
        }
    }
}
