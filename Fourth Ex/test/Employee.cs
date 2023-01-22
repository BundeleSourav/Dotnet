namespace HR;

public class Employee{
    public virtual void CalculateSalary(){
        Console.WriteLine("Employee: CalculateSalary");
    }

    public virtual void Dowork(){

    }
}

public class SalesEmployee:Employee{
    public new virtual void CalculateSalary(){
        Console.WriteLine("SalesEmployee Constructor");
    }

    public override void Dowork()
    {
        base.Dowork();
    }
}

public class SalesManager:SalesEmployee{
    public override void CalculateSalary()
    {
        base.CalculateSalary();
    }
}

