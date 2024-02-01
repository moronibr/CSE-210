using System;

public class Account
{
    private int _balance;

    public Account(int initialBalance)
    {
        _balance = initialBalance;
    }

    public int Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public void Deposit(int amount)
    {
        _balance += amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account savings = new Account(50);
        savings.Deposit(100);
        
     
        Console.WriteLine($"Saldo atual: {savings.Balance}");
    }
}
