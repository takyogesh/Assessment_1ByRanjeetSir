using System.Collections;

namespace Assignment_1byRanjeetSir
{
    public class Que_3
    {
        ArrayList list;
        int number;

        public Que_3()
        {
            list = new ArrayList() { 325, 750, 478 };
            number = int.MinValue;
        }
        public void LargestValue()
        {
            foreach(int num in list)
            {
                if(num > number)
                {
                    number = num;
                }
            }
            Console.WriteLine("Lagest Value is "+number);
        }
    }
}
