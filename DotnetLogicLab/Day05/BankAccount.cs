namespace CSharpPractise.DotnetLogicLab.Day05;

public class BankAccount
{
    private int accountNumber;
    private float accountBalance;

    public int AccountNumber
    {
        get{return accountNumber;}
    }
    
    public float AccountBalance
    {
        get{return accountBalance;}
    }

    public BankAccount(int accountNumber, float accountBalance)
    {
        this.accountNumber = accountNumber;
        this.accountBalance = accountBalance;
    }

    public void Deposit(float amount)
    {
        this.accountBalance += amount;
        Console.WriteLine("Deposited amount: " + amount + "available balance " + this.accountBalance);
    }

    public void Withdraw(float amount)
    {
        if (accountBalance < amount)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            this.accountBalance -= amount;
        }
        Console.WriteLine("Withdrawn amount: " + amount+ "available balance " + this.accountBalance);
    }
}