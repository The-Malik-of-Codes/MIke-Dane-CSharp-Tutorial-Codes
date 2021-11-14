using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            Console.WriteLine();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakeSpecialDish();
            italianChef.MakePasta();
            Console.ReadLine();
        }
    }
}
