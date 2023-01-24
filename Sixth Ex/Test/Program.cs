using RBI;
using Bank;

Government govt=new Government();

TaxOperation itOperation=new TaxOperation(govt.DeductIncomeTax);
TaxOperation proOperation=new TaxOperation(govt.DeductServiceTac);
TaxOperation ppOperation=new TaxOperation(govt.DeductPrivateTax);
TaxOperation acOperation=new TaxOperation(govt.FreezeAccount);

Console.WriteLine("Enter Initial Amount");
double amount12=double.Parse(Console.ReadLine());
Account acnt=new Account(amount12);

if(amount12>50000)
{
    acnt.Overbalance+=itOperation;
}
else if(amount12>250000 && amount12<=500000)
{
    acnt.Overbalance+=proOperation;
}
else if(amount12<=250000)
{
    acnt.Overbalance+=ppOperation;
}


Console.WriteLine("Enter Your Choice 1.Withdraw 2.Deposit");
int choice=int.Parse(Console.ReadLine());
Console.WriteLine("Enter Amount to be Deposited");
double amount= double.Parse(Console.ReadLine());
switch(choice)
{
    case 1:
        acnt.Withdraw(amount);
        break;
    case 2:
        acnt.Deposit(amount);
        break;
}

if(acnt.Balance<5000)
{
    acnt.Underbalance+=acOperation;
}
Console.WriteLine("Before Tax Processing");
Console.WriteLine(acnt);

acnt.ProcessTax();
Console.WriteLine("After Tax Processing");
Console.WriteLine(acnt);
