using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Books of Jacob",18, "Olga Tokarczuk",344);
            book1.Count = 12;
            Book book2 = new Book("Blood Feast",44,"Malika Moustadraf",562);
            Book book3 = new Book("At the Edge of the Woods",34, "Masatsugu Ono",667);
            Book book4 = new Book("The Employees",12, "Olga Ravn",123);
            Book book5 = new Book("A Few Collectors", 23,"Pierre Le-Tan",255);
            Library library = new Library(10);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            book1.ShowInfo();
            book1.Sell();
            book1.Sell();
            Console.WriteLine(book1.Count);
            library.GetBookById(1);
            library.GetBookById(20);


        }
    }
}
