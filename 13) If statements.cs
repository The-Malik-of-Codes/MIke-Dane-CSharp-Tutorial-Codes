using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            if (isMale)
            {
                Console.WriteLine("You are a male.");
            }
            else
            {
                Console.Out.WriteLine("You are not a male.");
            }

            if (isMale && isTall)
            {
                Console.Out.WriteLine("You are a tall male.");
            }
            else if (isMale || isTall)
            {
                Console.WriteLine("You are ethier a male or not tall or both.");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall.");
            }
            else
            {
                Console.WriteLine("You are ethier a male or not tall or both.");
            }
            Console.ReadLine();
        }
    }
}
