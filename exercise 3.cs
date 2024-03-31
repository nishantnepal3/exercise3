using System;

public class BankAccount
{
    // Properties
    public int AccountNumber { get; }
    public decimal Balance { get; private set; }
    public string Type { get; }

    // Constructors
    public BankAccount(int accountNumber) : this(accountNumber, "Checking") { }

    public BankAccount(int accountNumber, string type)
    {
        AccountNumber = accountNumber;
        Type = type;
        Balance = 0;
    }

    // Methods
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
        }
    }

    // Overloaded methods
    public void Deposit(decimal amount, string description)
    {
        Deposit(amount);
        Console.WriteLine($"Description: {description}");
    }

    public void Withdraw(decimal amount, string description)
    {
        Withdraw(amount);
        Console.WriteLine($"Description: {description}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating different types of accounts
        BankAccount checkingAccount = new BankAccount(1991);
        BankAccount savingAccount = new BankAccount(1998, "Saving");

        // Depositing and withdrawing from the accounts
        checkingAccount.Deposit(1000);
        savingAccount.Deposit(1500);

        checkingAccount.Withdraw(500);
        savingAccount.Withdraw(900);

        // Overloaded methods
        checkingAccount.Deposit(300, "ATM deposit");
        savingAccount.Withdraw(500, "Emergency fund");

        Console.ReadLine();
    }
}
