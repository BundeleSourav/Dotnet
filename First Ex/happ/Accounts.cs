namespace Banking;

public class Accounts{

    private float balance=80000;

    public float Getbalance()
    {
        return this.balance;
    }

    public void Setbalance(float amount)
    {
        this.balance=amount;
    }

    public Accounts()
    {
        this.balance=0;
    }

    public Accounts(float amount)
    {
        this.balance=amount;
    }

    public void Withdraw(float amount)
    {
        if(amount==0)
        {
            throw new Exception("Amount cannot be zero");
        }
        this.balance-=amount;
    }

    public void Deposit(float amount)
    {
        this.balance+=amount;
    }
}