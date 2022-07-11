using System.Collections;
namespace Assignment_1byRanjeetSir
{
    public class Que_1
    {
        ArrayList list;
        int oddCount;
        int evenCount;

        public Que_1()
        {
            list = new ArrayList() { -50, 65, 56, 71, 81 };
            oddCount = 0;
            evenCount = 0;
        }

        public void count()
        {
            foreach(int i in list)
            {
                if (i % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            Console.WriteLine("Odd Number Count - " + oddCount);
            Console.WriteLine("Even Number Count - " + evenCount);
        }
    }
}
