namespace CSharpPractise.CsharpLessons.TopicWisePractice;

public class BankAccount
{
    private readonly string _holderName;
    private double _balance;
    private string _accountNumber;

    public BankAccount(string accountNumber,string holderName, double balance)
    {
        this._accountNumber=accountNumber;
        this._holderName=holderName;
        this._balance=balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            this._balance += amount;
            Console.WriteLine("The deposit amount is " + amount +" your current balance "+this._balance);
        }
        else
        {
            Console.WriteLine("The deposit amount is negative");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= _balance)
        {
            this._balance -= amount;
            Console.WriteLine($"Withdrawn amount is {amount} your current balance {this._balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"--Account Information--");
        Console.WriteLine($"Account Number: {_accountNumber}");
        Console.WriteLine($"Holder Name: {_holderName}");
        Console.WriteLine($"Balance: {_balance}");
    }
}