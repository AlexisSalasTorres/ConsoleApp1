using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
            {
                new Book ("The Great Gatsby", "F. Scott Fitzgerald", "123456789", 180),
                new Magazine ("National Georaphic", "Various", "987654321", 100)

            };
            foreach (var item in libraryItems)
            {
                item.DisplayDetails();
                Console.WriteLine();

                item.BorrowItem();
                Console.WriteLine();

                item.BorrowItem();
                Console.WriteLine();

            }
            Console.ReadLine();
            
        }
    }
}
