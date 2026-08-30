using System;
using System.Collections.Generic;
using System.Text;

namespace Q1.BankAccount
{
    public class BankAccount
    {
        public string AccountNumber {  get; set; }
        public decimal Balance {  get;private set; }//only assigned from bank account class
        public BankAccount(string accountNumber, decimal balance = 0)//0 is the default
        {
            this.AccountNumber = accountNumber;
            this .Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (!IsValidDeposit(amount))//checks if the number written is positive
            {
                Console.WriteLine("Amount must be positive");
                return;
            }
            Balance += amount;//adds amount to balance

        }
        public void Withdraw(decimal amount) {
            if (!IsValidWithdrawl(amount)) //checks if the balance is enough and postitive


            {
                Console.WriteLine("Insufficient Balance");
                return;
            }
            Balance-= amount;//removes amount from balance
        }
        private bool IsValidDeposit(decimal amount) {
            return amount > 0;

        }
        private bool IsValidWithdrawl(decimal amount) {
            return amount > 0 && amount <= Balance;
        }
        public override string ToString() {
            return $"Account Number:{AccountNumber}" +
                    $"\nBalance:${Math.Round(Balance, 2):NO}";
        }
          

    }
}
