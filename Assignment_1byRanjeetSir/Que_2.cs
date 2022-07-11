namespace Assignment_1byRanjeetSir
{
    public class Que_2
    {
        int integerNum = 24;
        object objNumber = 30;


        public void Boxing()
        {
            object obj = integerNum;
            // the integerNum is integer type and will convert to object i.e referance type...is boxing
            Console.WriteLine("Boxing " + obj);
        }
        public void UnBoxing()
        {
            int num =(int)objNumber;
            // the objNumber is referance type and will convert to value type ...is Unboxing
            Console.WriteLine("Boxing " + num);
        }
    }
}
