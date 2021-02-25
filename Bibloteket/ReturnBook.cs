using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bibloteket
{
    class ReturnBook
    {
        public static void Return(string choice)
        {
            switch(choice)
            {
                case "Y":
                case "Yes":
                    string book = LoanBook.bookStack.Pop().ToString();
                    Book.books.Add(book);
                    Book.loanedBooks.Remove(book);

                    Console.WriteLine("Successfully returned!");

                    Thread.Sleep(1500);
                    Console.Clear();
                    cnsl.LoadMenu();
                    break;

                case "N":
                case "No":
                    Console.WriteLine("Heading back to menu..");

                    Thread.Sleep(1500);
                    Console.Clear();
                    cnsl.LoadMenu();
                    break;
            }
        }
    }
}
