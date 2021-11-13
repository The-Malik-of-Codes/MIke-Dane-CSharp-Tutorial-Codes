using System;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies avengers = new Movies("The Avengers", "Joss Whedon", "PG-13");
            Movies shreik = new Movies("Shriek", "Adam Adamson", "PG");
            Movies dune = new Movies("Dune", "Sherlock Holmes", "Dog");
            
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shreik.Rating);
            Console.WriteLine(dune.Rating);
            Console.ReadLine();
        }
    }
}
 