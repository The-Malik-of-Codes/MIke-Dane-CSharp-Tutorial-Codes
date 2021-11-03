using System;

namespace MoreIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(GetMax(2, 6));
            Console.WriteLine(GetMax(42, 6));

            Console.WriteLine(MaxNum(10, 30, 60));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2) // This are comparism operator.
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        static int MaxNum(int num3, int num4, int num5)
        {
            int result;
            if (num3 >= num4 && num3 >= num5) // This is a comparism operator.
            {
                result = num3;
            }
            else if (num4 >= num3 && num4 >= num5)
            {
                result = num4;
            }
            else
            {
                result = num5;
            }
            return result;
        }
    }
}
