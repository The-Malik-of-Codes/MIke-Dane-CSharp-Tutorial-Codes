using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_in_classes
{
    class Books
    {
        public string title;
        public string author;
        public int pages;

        public Books(string name)
        {
            Console.WriteLine("Creating a new book called " + name);
        }

        public Books(string aTitles, string aAuthor, int aPages)
        {
            title = aTitles;
            author = aAuthor;
            pages = aPages;
        }
    }
}
