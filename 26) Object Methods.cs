using System;

namespace Object_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("salim Abidoye", "Surveying Engineering", 4.57);
            Student student2 = new Student("Seun Shorty", "Civil Engineering", 4.7);
            Student student3 = new Student("Abdul Salam", "Mechanical Engineering", 3.8);
            Student student4 = new Student("Olakunle Bolu", "Computer Engineering", 2.5);

            Console.WriteLine(student2.name);
            Console.WriteLine(student3.major);
            Console.WriteLine(student1.gpa);
            Console.WriteLine(student4.gpa);
            Console.WriteLine();

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
            Console.WriteLine(student3.HasHonours());
            Console.WriteLine(student4.HasHonours());

            Console.ReadLine();
        }
    }
}
