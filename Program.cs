using ATMApplication.Classes;
using System;

namespace ATMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOne("12345678", "1234", 500, 100);
            TestTwo("23634717", "6223", 800, 200);
            TestThree("79365185", "7832", 400, 100);
            TestFour("96257643", "5132", 10000, 1000);
            TestFive("79376392", "2894", 3000, 1000);
        }

        public static void TestOne(string accountNum, string piNum, int bal, int over)
        {
            string accountNumber = accountNum;
            string pin = piNum;
            string enteredPIN = pin;
            int balance = bal;
            int overdraft = over;
            BankAccount account = new(accountNumber, pin, balance, overdraft);
            ATM atm = new(8000, account);

            Console.WriteLine($"ATM initial balance: {atm.GetBalance()}");

            DisplayInput(accountNumber, pin, enteredPIN, balance, overdraft);

            Console.WriteLine();
            Console.WriteLine($"Balance check: {atm.CheckAccountBalance(enteredPIN)}");
            Console.WriteLine("Withdraw 200");
            Console.WriteLine($"{atm.WithdrawMoney(200, enteredPIN)}\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
        }

        public static void TestTwo(string accountNum, string piNum, int bal, int over)
        {
            string accountNumber = accountNum;
            string pin = piNum;
            string enteredPIN = "5163";
            int balance = bal;
            int overdraft = over;
            BankAccount account = new(accountNumber, pin, balance, overdraft);
            ATM atm = new(8000, account);

            Console.WriteLine($"ATM initial balance: {atm.GetBalance()}");

            DisplayInput(accountNumber, pin, enteredPIN, balance, overdraft);

            Console.WriteLine($"Balance check: {atm.CheckAccountBalance(enteredPIN)}");
            Console.WriteLine("Withdraw 200");
            Console.WriteLine($"{atm.WithdrawMoney(200, enteredPIN)}\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
        }

        public static void TestThree(string accountNum, string piNum, int bal, int over)
        {
            string accountNumber = accountNum;
            string pin = piNum;
            string enteredPIN = pin;
            int balance = bal;
            int overdraft = over;
            BankAccount account = new(accountNumber, pin, balance, overdraft);
            ATM atm = new(8000, account);

            Console.WriteLine($"ATM initial balance: {atm.GetBalance()}");

            DisplayInput(accountNumber, pin, enteredPIN, balance, overdraft);

            Console.WriteLine();
            Console.WriteLine($"Balance check: {atm.CheckAccountBalance("7832")}");
            Console.WriteLine("Withdraw 300");
            Console.WriteLine($"{atm.WithdrawMoney(300, enteredPIN)}\n");
            Console.WriteLine("Withdraw 500");
            Console.WriteLine($"{atm.WithdrawMoney(500, enteredPIN)}\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
        }

        public static void TestFour(string accountNum, string piNum, int bal, int over)
        {
            string accountNumber = accountNum;
            string pin = piNum;
            string enteredPIN = pin;
            int balance = bal;
            int overdraft = over;
            BankAccount account = new(accountNumber, pin, balance, overdraft);
            ATM atm = new(8000, account);

            Console.WriteLine($"ATM initial balance: {atm.GetBalance()}");

            DisplayInput(accountNumber, pin, enteredPIN, balance, overdraft);

            Console.WriteLine();
            Console.WriteLine($"Balance check: {atm.CheckAccountBalance(enteredPIN)}");
            Console.WriteLine("Withdraw 9000");
            Console.WriteLine($"{atm.WithdrawMoney(9000, enteredPIN)}\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
        }

        public static void TestFive(string accountNum, string piNum, int bal, int over)
        {
            string accountNumber = accountNum;
            string pin = piNum;
            string enteredPIN = pin;
            int balance = bal;
            int overdraft = over;
            BankAccount account = new(accountNumber, pin, balance, overdraft);
            ATM atm = new(0, account);

            Console.WriteLine($"ATM initial balance: {atm.GetBalance()}");

            DisplayInput(accountNumber, pin, enteredPIN, balance, overdraft);

            Console.WriteLine();
            Console.WriteLine($"Balance check: {atm.CheckAccountBalance(enteredPIN)}");
            Console.WriteLine("Withdraw 9000");
            Console.WriteLine($"{atm.WithdrawMoney(500, enteredPIN)}\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
        }

        public static void DisplayInput(string accountNumber, string pin, string enteredPIN, int balance, int overdraft)
        {
            Console.WriteLine($"Input Account number: {accountNumber}");
            Console.WriteLine($"Input PIN: {pin}");
            Console.WriteLine($"Entered PIN: {enteredPIN}");
            Console.WriteLine($"Input balance: {balance}");
            Console.WriteLine($"Input overdraft: {overdraft}");
            Console.WriteLine();
        }
    }
}
