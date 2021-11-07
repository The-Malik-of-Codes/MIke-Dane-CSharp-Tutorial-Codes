using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Eenter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 / num2);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("That how it is done.");
            }

            Console.ReadLine();
        }
    }
}
