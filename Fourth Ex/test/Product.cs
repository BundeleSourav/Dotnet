namespace  catalog;

public class Product:IDisposable{
    public Product(){

    }

    public string Title{get;set;}
    public double Price{get;set;}

    public void Dispose()
    {
        Console.WriteLine("Dispose is Invoked.....");
        GC.SuppressFinalize(this);
    }

    ~Product(){
        Console.WriteLine("Inside Destructor.........");
    }

}

