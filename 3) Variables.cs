using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Imran Khalid";
            int characterAge = 18;
            
            Console.WriteLine("There once was a guy called " + characterName + ".");
            Console.WriteLine("He was " + characterAge + " years old.");

            characterName = "Muhammad";
            Console.WriteLine("He really liked the name " + characterName + ".");
            Console.WriteLine("But didn't being " + characterAge + " years old.");
            Console.ReadLine();
        }
    }
}