using System.Reflection;
string path=@"G:\Practice html\dotnet\fifth\Faculty\bin\Debug\net7.0\Faculty.dll";
Assembly asm=Assembly.LoadFile(path);
string name=asm.FullName;
Console.WriteLine(name);

Type[] types=asm.GetTypes();
for(int i=0;i<types.Count();i++)
{
    string typeName=types[i].Name;
    Console.WriteLine(typeName);
    MethodInfo [] mi=types[i].GetMethods();
    foreach (MethodInfo m in mi)
    {
        String methodName=m.Name;
        Console.WriteLine(methodName);
    }
}
