using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    class Book
    {
        public static List<string> books = new List<string>();
        public static List<string> loanedBooks = new List<string>();

        public Book()
        {

        }

        public void AddBook(string name)
        {
            books.Add(name);
        }

        public void AddAllBooks()
        {
            books.Add("Harry Potter and the Philosopher's Stone");
            books.Add("Harry Potter and the Chamber of Secrets");
            books.Add("Harry Potter and the Prisoner of Azkaban");
            books.Add("Harry Potter and the Goblet of Fire");
            books.Add("Harry Potter and the Order of the Phoenix");
            books.Add("Harry Potter and the Half-Blood Prince");
            books.Add("Harry Potter and the Deathly Hallows");
        }
    }
}
