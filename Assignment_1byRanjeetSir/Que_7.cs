namespace Assignment_1byRanjeetSir
{
    public class Que_7
    {
       public void OverloadConstuctor()
        {
            OverloadConstrutor overloadConstrutor = new OverloadConstrutor();
            Console.WriteLine(overloadConstrutor.ToString());

            overloadConstrutor = new OverloadConstrutor(1, "yogesh", 90);
            Console.WriteLine(overloadConstrutor.ToString());
        }
        
    }
    public class OverloadConstrutor
    {
        int id;
        string? name;
        int marks;
        public OverloadConstrutor()
        {
            id = 0;
            name = null;
            marks = 0;
        }

        public OverloadConstrutor(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public override string ToString()
        {
            return "Id : " + id + " Name : " + name + " Marks : " + marks + "";
        }

    }
}
