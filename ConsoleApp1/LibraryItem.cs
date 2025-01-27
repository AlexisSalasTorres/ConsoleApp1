using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        public LibraryItem(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsBorrowed = false;

        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
            Console.WriteLine($"Status: {(IsBorrowed ? "Borrowed" : "Available")}");

        }
        public bool BorrowItem()
        {
            if (IsBorrowed)
            {
                Console.WriteLine("The item \"{Title}\" is already borrowed.");
                return false;
            }
            IsBorrowed = true;
            Console.WriteLine($"you have successfully borrowed \"{Title}\".");
            return true;

            }
       
        }
 

    }