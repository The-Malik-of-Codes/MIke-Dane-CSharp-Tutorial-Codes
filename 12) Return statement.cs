using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubeNumber = cube(9);
            Console.WriteLine(cubeNumber);
            
            Console.WriteLine(cube(5));
            Console.WriteLine(cube(6));
            Console.WriteLine( cube(81));
            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
