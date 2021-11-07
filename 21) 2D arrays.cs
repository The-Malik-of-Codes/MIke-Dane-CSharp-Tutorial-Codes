using System;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {0, 2},
                {2, 4},
                {4, 6},
                {6, 8},
                {8, 10}
            };
            int[,] myArray = new int[2, 8];
            Console.WriteLine(numberGrid[3, 1]);
            Console.WriteLine(myArray[0, 1]);
            Console.ReadLine();
        }
    }
}
