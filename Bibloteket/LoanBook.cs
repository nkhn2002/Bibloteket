using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Bibloteket
{
    class LoanBook
    {
        public static Stack bookStack = new Stack();

        public static void Loan(string book)
        {
            if(Book.books.Contains(book))
            {
                bookStack.Push(book);
                Book.books.Remove(book);
                Book.loanedBooks.Add(book);
                Console.WriteLine("Successfully booked!");

                Thread.Sleep(1500);
                Console.Clear();
                cnsl.LoadMenu();
            }
            else
            {
                Console.WriteLine("Invalid book");
                return;
            }
        }
    }
}
