using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Author : Person
{
    public List<Book> BookList { get; set; }

    public Author(string firstName, string lastName) : base(firstName, lastName)
    {
        BookList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        BookList.Add(book);
    }
}

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, Author author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }
}

public class Reader : Person
{
    public List<Book> BorrowedBooksList { get; set; }
    public Reader(string firstName, string lastName) : base(firstName, lastName)
    {
        BorrowedBooksList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        BorrowedBooksList.Add(book);
        Console.WriteLine($"Czytelnik {FirstName} {LastName} wypożyczył książkę: {book.Title}");
    }
}

namespace _2_dziedziczenie_kompozycja_biblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Adam", "Mickiewicz");
            Book book = new Book("Pan Tadeusz", author, 1834);
            Console.ReadKey();
        }
    }
}