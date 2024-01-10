namespace task_8;

public class BankAccount
{
    int accountId;
    decimal balance;
    public string OwnerName { get; set; }
    bool isFrozen;

    public BankAccount(int accountId, decimal balance, string OwnerName)
    {
        this.accountId = accountId;
        this.balance = balance;
        this.OwnerName = OwnerName;
    }

    public void Deposit(decimal amount)
    {
        if (isFrozen == false)
        {
            System.Console.WriteLine("Frozen account");
        }
        else if (amount < 0)
        {
            System.Console.WriteLine("Negative number");
        }
        else
        {
            balance = balance + amount;
            System.Console.WriteLine("Balance : " + balance);
        }
    }
    public void Withdraw(decimal amount)
    {
        if (isFrozen == false)
        {
            System.Console.WriteLine("Frozen account");
        }
        else if (amount > balance)
        {
            System.Console.WriteLine("Not enought money");
        }
        else
        {
            balance = balance - amount;
        }
    }

    public void FreezeAccount()
    {
        isFrozen = false;
    }
    public void UnfreezeAccount()
    {
        isFrozen = true;
    }
}
