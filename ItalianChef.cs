using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes sharwarma.");
        }

        public void MakePasta()
        {
            Console.Write("The chef makes pasta.");
        }



    }
}
