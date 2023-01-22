using HR;
// using Catalog;
using Library;
using Training;

const string ins="IACSD";
const int result=89;

Person p1=new Person();
// p1.FirstName="Durgesh";
// p1.LastName="Wagh";
// p1.Id=42;
// Console.WriteLine("ID:- "+Id+" Firstname:- "+FirstName+" LastName:- "+LastName);

// p1.display("CPP");
// p1.display("WPT","DSA",".NET","COP");
// p1.display("DBT");
// p1.display("JAVA","AD JAVA","SDM");

double area=10;
double circumference=10;
Console.WriteLine("area={0},circumference={1}",area,circumference);
Console.WriteLine("area={0},circumference={1}",area,circumference);



int [] num={45,21,65,32,87};
string [] name={"Raj","Sam","Rony","Drax","Groot","Yoda"};

Books mycollections=new Books();
string titles=mycollections[0];
Console.WriteLine("Title:- "+titles);
mycollections[3]="Advance Java";
titles=mycollections[3];
Console.WriteLine("Titles:- "+titles);


Student std1=new Student();


Employee emp=new Employee();
emp.CalculateSalary();

SalesEmployee semp=new SalesEmployee();
semp.CalculateSalary();

Employee e3=semp;
e3.CalculateSalary();

Stack flanded=new Stack(3);
Stack flanded=(Stack)flightsLanded.Clone();

