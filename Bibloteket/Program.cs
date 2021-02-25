using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bibloteket
{
    class Program
    {
        public static int Choice { get; set; }
        public static string bookLoan { get; set; }
        public static string bookReturn { get; set; }
        static void Main(string[] args)
        {
            Book book = new Book();

            // Add books to list
            book.AddAllBooks();

            // Load menu
            cnsl.LoadMenu();

            while (true)
            {
                Console.Write("\nEnter a choice: ");
                try
                {
                    Choice = int.Parse(Console.ReadLine());
                }
                catch { Console.Clear(); cnsl.LoadMenu(); }

                switch (Choice)
                {
                    case 1:
                        Loan();
                        break;

                    case 2:
                        Return();
                        break;

                    default:
                        Console.Clear();
                        cnsl.LoadMenu();
                        break;
                }
            }
        }

        public static void Loan()
        {
            Console.WriteLine("\n====================");
            if (Book.books.Count > 0)
            {
                Console.WriteLine("Available Books: ");
                foreach (string item in Book.books)
                {
                    Console.WriteLine(item);

                }
            }
            else
            {
                Console.WriteLine("No books available!");

                Thread.Sleep(1500);
                Console.Clear();
                cnsl.LoadMenu();
                return;
            }

            Console.Write("\nEnter book name: ");
            bookLoan = Console.ReadLine();

            LoanBook.Loan(bookLoan);
        }

        public static void Return()
        {
            Console.WriteLine("\n====================");
            if (Book.loanedBooks.Count > 0)
            {
                Console.WriteLine("Your Books: ");
                foreach (string item in Book.loanedBooks)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("You haven't loaned any books!");

                Thread.Sleep(1500);
                Console.Clear();
                cnsl.LoadMenu();
                return;
            }

            Console.Write("\nDo you want to return the books? (Y/N): ");
            bookReturn = Console.ReadLine();

            ReturnBook.Return(bookReturn);
        }
    }
}
