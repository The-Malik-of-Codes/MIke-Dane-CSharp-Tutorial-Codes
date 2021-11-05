using System;

namespace For_loops
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine(i);
            }
            int[] luckyNumbers = { 1, 5, 45, 15, 4, 15, 3, 8 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);

            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
