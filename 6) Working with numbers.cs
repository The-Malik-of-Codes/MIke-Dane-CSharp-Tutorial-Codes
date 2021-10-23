using System;

namespace WorkingWithNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(10);
            Console.WriteLine(507);
            Console.WriteLine(-2005);
            Console.WriteLine(4.3566);
            Console.WriteLine(-3.1425);
            Console.WriteLine(10 + 915);
            Console.WriteLine(541 - 526);
            Console.WriteLine(87 / 355);
            Console.WriteLine(584 % 4);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 9) * 8);
            Console.WriteLine(48.68 - 54.2);
            Console.WriteLine(5 / 2); // it will give a whole number i.e 2.
            Console.WriteLine(5 / 2.0); // it will give you 2.5 so the divider must be in decimal.

            // in form of variable
            int num = 9;
            num++;
            Console.WriteLine(num);
            int num2 = 8;
            num2--;
            Console.WriteLine(num2);
            // math functions
            Console.WriteLine(Math.Abs(-545));
            Console.WriteLine(Math.Pow(6, 5));
            Console.WriteLine(Math.Sqrt(613));
            Console.WriteLine(Math.Max(6, 5));
            Console.WriteLine(Math.Min(8, 2));
            Console.WriteLine(Math.Round(5.54));
            Console.ReadLine();
        }
    }
}