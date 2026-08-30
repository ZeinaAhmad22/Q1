using Q1.BankAccount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123987", 100);

        account.Deposit(50);//new balace=150
        account.Withdraw(200);//insufficient balance
        account.Withdraw(90);//new balance=60
        account.Deposit(-5);//amount must be positive
        Console.WriteLine(account.ToString());

    }
}