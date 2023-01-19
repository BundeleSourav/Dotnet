using System.Collections.Generic;
using Banking;
using Maths;

var p=new {
    FirstName="Sourav",
    LastName="Bundele"
};

Console.WriteLine(p.FirstName+" "+p.LastName);

int count=12;
Console.WriteLine("Count = "+count);
// Console.WriteLine(company);
Console.WriteLine("Hello! World");

Accounts acc11=new Accounts(90000);
acc11.Deposit(10000);
float currentbal=acc11.Getbalance();

Accounts acc12=new Accounts(80000);
acc12.Withdraw(10000);
float currentbal1=acc12.Getbalance();

List<Accounts> accounts=new List<Accounts>();
accounts.Add(acc11);
accounts.Add(acc12);


foreach(Accounts ac in accounts)
{
    float result=ac.Getbalance();
    Console.WriteLine("Current Balance={0} ",result);
}

Complex c1=new Complex(12,45);
Complex c2=new Complex(36,55);
Complex c3=c1+c2;
