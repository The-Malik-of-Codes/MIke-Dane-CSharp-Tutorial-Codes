using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mus \nTech \nWorld");
            Console.WriteLine("Giraffe \" Academy"); // this is when you want to write a sentece starting with ("").
            // String functions
            string pharse = "The Malik of Codes";
            Console.WriteLine(pharse + " is cool.");
            Console.WriteLine(pharse.Length);
            Console.WriteLine(pharse.ToUpper());
            Console.WriteLine(pharse.ToLower());
            Console.WriteLine(pharse.Contains("Malik"));
            // indexing
            Console.WriteLine(pharse[0]);
            Console.WriteLine(pharse[2]);
            Console.WriteLine(pharse[4]);
            Console.WriteLine(pharse[6]);
            Console.WriteLine(pharse[8]);
            Console.WriteLine(pharse[10]);
            Console.WriteLine(pharse[12]);
            Console.WriteLine(pharse[14]);
            Console.WriteLine(pharse[16]);
            Console.WriteLine(pharse.IndexOf("The"));
            Console.WriteLine(pharse.IndexOf('C'));
            Console.WriteLine(pharse.IndexOf('z'));
            Console.WriteLine(pharse.Substring(4));
            Console.WriteLine(pharse.Substring(4, 5));
            Console.ReadLine();
        }
    }
}
