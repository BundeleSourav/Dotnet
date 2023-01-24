namespace RBI;

public delegate void TaxOperation(double amount);


public class Government
{
    // if(double amount>=500000)
    
    public void DeductIncomeTax(double amount)
    {
        Console.WriteLine("15% income tax is deducted from your account");
        return;
    }
    
    // elseif(double amount>=250000 && amount<=500000)
    
    public void DeductServiceTac(double amount)
    {
        Console.WriteLine("10% Private tax is deducted from your account");
        return;
    }
    
    
    public void DeductPrivateTax(double amount)
    {
        Console.WriteLine("5% service tax is deducted from your account");
    }

    public void FreezeAccount(double amount)
    {
        Console.WriteLine("Account is Freezed because balance is less than minimum amount");
    }
}
