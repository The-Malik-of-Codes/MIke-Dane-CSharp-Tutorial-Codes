using System;

namespace While_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            int index = 1;
            while (index <= 999)
            {
                Console.WriteLine(index);
                index++;
            }

            // For a do-while loop
            int indices = 118;
            do
            {
                Console.WriteLine(indices);
                indices++;
            }while (indices <= 8);

            Console.ReadLine();
        }
    }
}
