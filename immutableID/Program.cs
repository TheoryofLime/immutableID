using System;

namespace immutableId
{
    class Student
    {
        // auto-implemented properties
        public  int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        // id constructor
        public Student(int i)
        {
            Id = i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1);
            Student student2 = new Student(2, "fname2", "lname2");

            student1.FirstName = "fname1";
            student1.LastName = "lname1";

            Console.WriteLine(student1.Id);
            Console.WriteLine(student1.FirstName);
            Console.WriteLine(student1.LastName);
            Console.WriteLine("///");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);
        }
    }
}