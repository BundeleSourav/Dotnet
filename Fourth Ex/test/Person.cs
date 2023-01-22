namespace HR;
    public sealed class Person{

        private double PI;
        private int Id{get;set;}
        private string FirstName{get;set;}
        private string LastName{get;set;}

        public static Person _ref=null;

        public Person(){
            this.Id=1;
            this.FirstName="Sourav";
            this.LastName="Bundele";
            PI=3.14;
        }

        public static Person Createinstance(){
            if(_ref==null)
            {
                _ref=new Person();
            }
            return _ref;
        }

        public void display(params string [] subjects)
        {
            foreach(string s in subjects)
            {
                Console.WriteLine(s);
            }
        }

        public void Swap(ref int num1,ref int num2)
        {
            int temp=num1;
            num1=num2;
            num2=temp;
        }


        public void Calculate(int radius,out double area,out double circumference)
        {
            area=PI*radius*radius;
            circumference=2*PI*radius;
        }
    }
