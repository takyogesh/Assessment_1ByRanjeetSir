using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1byRanjeetSir
{
    public class Que_10
    {
        List<Student> list = new List<Student>() 
        {
            new Student(1, "akash", 15),
            new Student(2, "parag", 22),
            new Student(3, "vinay", 19),
            new Student(4, "krishna", 14),
            new Student(5, "akshay", 28),
            new Student(6, "rohit", 12)
        };

        public void teenagerStudent()
        {
            var teenager = list.Where(stu => stu.Age < 18);
            foreach(var student in teenager)
            {
                Console.WriteLine(student.Id+" "+student.Name+" "+student.Age);
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int Id, string Name, int Age)
        {
            this.Id = Id;
           this. Name = Name;
           this. Age = Age;
        }
        //public override string ToString()
        //{
        //    return "Id : " + Id + " Name : " + Name + " Age : " + Age + "";
        //}
    }
}
