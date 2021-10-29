using System;

namespace BuildingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("85" + "31"); // The output of this will be 8531.


            int num = Convert.ToInt32("52");
            Console.WriteLine(num + 46);


            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 * num2);

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 / num4);

            Console.ReadLine();
        }
    }
}