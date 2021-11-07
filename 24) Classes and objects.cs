using System;


namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                title = "Advanced Chemistry",
                author = "O.S. Ababio",
                pages = 1596
            };

            Book book2 = new Book
            {
                title = "Harry Potter",
                author = "JK Rowling",
                pages = 450
            };

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine();

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
