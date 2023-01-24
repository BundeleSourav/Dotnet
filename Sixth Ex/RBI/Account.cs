namespace Bank;

using RBI;

public class Account{

    public event TaxOperation Overbalance;
    public event TaxOperation Underbalance;
    public double Balance{get;set;}
    public Account(double amount)
    {
        this.Balance=amount;
    }

    public void Withdraw(double amount)
    {
        this.Balance-=amount;
    }

    public void Deposit(double amount)
    {
        this.Balance+=amount;
    }

    public override string ToString()
    {
        return base.ToString()+" Current Balance:- "+this.Balance;
    }

    public void ProcessTax()
    {
        if(this.Balance>=250000)
        {
            Overbalance(this.Balance);
        }
        else if(this.Balance<=5000)
        {
            Underbalance(this.Balance);
        }
    }
}