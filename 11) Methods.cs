using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Tom");
            SayHi("Mike");
            SayHi("Dane");
            SayHi("John");

            Intro("Salam", 20);
            Intro("Code", 84);
            Intro("Mubby", 18);
            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        static void Intro(string name, int age)
        {
            Console.WriteLine("Hello " + name + "! are you " + age + " years old?");
        }
    }
}
