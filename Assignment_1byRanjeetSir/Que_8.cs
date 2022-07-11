namespace Assignment_1byRanjeetSir
{
    public class Que_8
    {
       public void ImplementInterface()
        {
            int n1=0;
            int n2=0;

            Console.WriteLine("Enter the num 1");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the num 1");
            n2 = Convert.ToInt32(Console.ReadLine());

            Computation computation = new Computation();
            computation.Add(n1, n2);
            computation.Multi(n1, n2);

        }

    }
    public class Computation : Addition , Multiplication
    {

        public void Add(int num1, int num2)
        {
            Console.WriteLine("Addition is : "+(num1 + num2));
        }

        public void Multi(int num1, int num2)
        {
            Console.WriteLine("Multiplication is : "+(num1 * num2));
        }
    }
    public interface Addition
    {
        void Add(int num1, int num2);
    }
    public interface Multiplication
    {
        void Multi(int num1, int num2);
    }
}
