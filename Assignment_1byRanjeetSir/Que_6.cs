namespace Assignment_1byRanjeetSir
{
    public class Que_6
    {
        List<string> list;

        public Que_6()
        {
            list = new List<string>() { "Delhi", "Mumbai", "Chennai", "Kolkata" };
        }

        public void Sort()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if ((list[i].CompareTo(list[j])) < 0)
                    {
                        string s = list[i];
                        list[i] = list[j];
                        list[j] = s;
                    }
                }
            }
            foreach (string s in list)
                Console.WriteLine(s);
        }
    }
}
