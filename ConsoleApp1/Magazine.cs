using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Magazine : LibraryItem

    {
        public  int IssueNumber { get; set; }
        public Magazine( string title, string author, string isbn, int issueNumber )
            :base(title, author,isbn)
        {
            IssueNumber = issueNumber;
        }
        public override void DisplayDetails()

        { base.DisplayDetails();
            Console.WriteLine( "Issue Number: {298572}");

        }
        
    }
}
