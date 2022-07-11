namespace Assignment_1byRanjeetSir
{
    public class Que_5
    {
        MethodOverload methodOverload = new MethodOverload();
        public void overLoad()
        {
            methodOverload=new MethodOverload(5,5);
            methodOverload=new MethodOverload(5,5,5);
            methodOverload=new MethodOverload(5,5,5,5);
        }
      

    }

    public class MethodOverload
    {
        public MethodOverload() { }
        public MethodOverload(int n1,int n2) 
        {
            Add(n1, n2);
        }
        public MethodOverload(int n1,int n2,int n3)
        {
            Add(n1, n2, n3);
        }
        public MethodOverload(int n1,int n2,int n3,int n4)
        {
            Add(n1, n2, n3, n4);
        }

        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);

        }
        public void Add(int num1, int num2,int num3)
        {
            Console.WriteLine(num1 + num2+num3);

        }
        public void Add(int num1, int num2,int num3,int num4)
        {
            Console.WriteLine(num1 + num2+num3+num4);

        }

    }
}
