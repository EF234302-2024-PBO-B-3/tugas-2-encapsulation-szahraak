using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    _balance = 0;
                } else
                {
                    _balance = value;
                }
            }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            if (string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(accountHolder))
            {
                AccountNumber = "Unknown";
                AccountHolder = "Unknown";
            } else
            {
                AccountNumber = accountNumber;
                AccountHolder = accountHolder;
            }
            if (balance < 0)
            {
                _balance = 0;
            }
            else
            {
                _balance = balance;
            }
        }

        public double Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return 0;
            }
            return 1;
        }

        public double Withdraw(double amount)
        {
            if (amount > 0 && (_balance - amount >= 0))
            {
                _balance -= amount;
                return 0;
            }
            return 1;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
