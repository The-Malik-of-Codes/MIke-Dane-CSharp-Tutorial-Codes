using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array hold mare item than a variable E.g:

            int[] luckyNumbers = { 4, 5, 8, 63, 894, 354, 3245 };



            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers[2]);
            luckyNumbers[3] = 9542;
            Console.WriteLine(luckyNumbers[3]);

            string[] friends = new string[4];
            friends[0] = "Boner";
            friends[1] = "Boneret";
            friends[2] = "Tim";
            friends[3] = "Thomas";
            friends[4] = "Sally";
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.ReadLine();
        }
    }
}
