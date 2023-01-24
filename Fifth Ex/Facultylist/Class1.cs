using Faculty;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Trainers f1=new Trainers{Id=21, FirstName="Drax"};
Trainers f2=new Trainers{Id=22, FirstName="Gru"};
Trainers f3=new Trainers{Id=23, FirstName="Sam"};
Trainers f4=new Trainers{Id=24, FirstName="Rony"};
Trainers f5=new Trainers{Id=25, FirstName="Groot"};

List<Trainers> trainer=new List<Trainers>();
trainer.Add(f1);
trainer.Add(f2);
trainer.Add(f3);
trainer.Add(f4);
trainer.Add(f5);

try
{
    var options=new JsonSerializerOptions{IncludeFields=true};
    var facJson=JsonSerializer.Serialize<List<Trainers>>(trainer,options);
    string fileName=@"F:\SDM\New.json";

    File.WriteAllText(fileName,facJson);

    string jsonString=File.ReadAllText(fileName);
    List<Trainers> jsonFac=JsonSerializer.Deserialize<List<Trainers>>(jsonString);
    Console.WriteLine("\n JSON :Deserializing Data \n");
    foreach (Trainers fac in jsonFac)
    {
        Console.WriteLine($"{fac.Id}:{fac.FirstName}");
    }
}
catch (Exception exp)
{
}
finally{}