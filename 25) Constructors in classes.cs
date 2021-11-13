using System;


namespace Constructors_in_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("Mike")
            {
                title = "Advanced Chemistry",
                author = "O.S. Ababio",
                pages = 1596
            };

            Books book2 = new Books("John")
            {
                title = "Harry Potter",
                author = "JK Rowling",
                pages = 450
            };
            book2.author = "Jimmy Fallon";
            Books book3 = new Books("Introduction to physics", "P.N. Okeke", 860);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine();

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
            Console.WriteLine();

            Console.WriteLine(book3.title);
            Console.WriteLine(book3.author);
            Console.WriteLine(book3.pages);
            Console.ReadLine();
        }
    }
}
