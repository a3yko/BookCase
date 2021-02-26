using System;

namespace BookCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Ready Player One", "Ernest Cline", 19.99, "978-0307887443");

           Console.WriteLine(myBook.printInformation());
        }
    }
}
