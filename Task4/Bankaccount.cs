public class Bankaccount
{
    int accountId;
    decimal balance;
    public string OwnerName;
    bool isFrozen;
    public Bankaccount(int accountId, decimal balance, string ownerName)
    {
        this.accountId = accountId;
        this.balance = balance;
        this.OwnerName = ownerName;
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        balance -= amount;
    }
    public void FreezeAccount()
    {
        isFrozen = true;
    }
    public void UnfreezeAccount()
    {
        isFrozen = false;
    }
}
