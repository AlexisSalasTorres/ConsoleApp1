using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book : LibraryItem
    {
        public int PageCount { get; set; }

        public Book(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount= pageCount;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
