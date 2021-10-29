using System;

namespace GettingUsersInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("You are welcome, oh " + name + ".");
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("You are welcome, oh " + name + " and you are " + age + " years old.");
            Console.ReadLine();
        }
    }
}
