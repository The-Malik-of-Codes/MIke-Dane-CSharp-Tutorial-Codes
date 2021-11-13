using System;

namespace Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Songs loading = new Songs("Loading", "Olamide", 5);
            Console.WriteLine(Songs.songCount);
            Songs havooc = new Songs("Havooc", "Joe Flizzow", 4);
            Console.WriteLine(Songs.songCount);

            Console.WriteLine();
            Console.WriteLine(loading.title);
            Console.WriteLine(havooc.title);
            Console.WriteLine(loading.getSongCount());
            Console.ReadLine();
        }
    }
}
