using System;

namespace Building_a_better_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine();
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine();
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine();
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine();
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadLine();
        } 
    }
}