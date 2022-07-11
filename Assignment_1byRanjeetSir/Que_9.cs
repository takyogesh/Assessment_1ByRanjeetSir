namespace Assignment_1byRanjeetSir
{
    public class Que_9
    {
        public void Dictionary()
        {
            ImplementDictionary implementDictionary = new ImplementDictionary();
            implementDictionary.PlayersList();
        }
    }
    public class ImplementDictionary
    {
        public void PlayersList()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Bumrah");
            dictionary.Add(2, "Ashwin R");
            dictionary.Add(3, "Dhawan");
            dictionary.Add(4, "MS Dhoni");
            dictionary.Add(5, "Sachin T");
            dictionary.Add(7, "Rahul D");
            dictionary.Add(8, "Virat Kohli");
            dictionary.Add(9, "MaxWell");
            dictionary.Add(10, "Steven Smith");
            dictionary.Add(11, "Nathan");

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
