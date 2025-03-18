using System;
using System.Collections.Generic;

namespace LibraryManagementSystem;

public class Catalog
{
    private Dictionary<string, List<Book>> bookTitles = new();
    private Dictionary<string, List<Book>> bookAuthors = new();
    private Dictionary<string, List<Book>> bookSubjects = new();
    private Dictionary<string, List<Book>> bookPublications = new();

    public void UpdateBook(Book book)
    {
        //Program.DisplayBook(book);

        // AUTHOR
        bookAuthors.TryAdd(book.Author, new List<Book>());
        bookAuthors[book.Author].Add(book);

        // TITLES
        bookTitles.TryAdd(book.Title, new List<Book>());
        bookTitles[book.Title].Add(book);

        // PUBLICATION
        bookPublications.TryAdd(book.Publisher, new List<Book>());
        bookPublications[book.Publisher].Add(book);

        // SUBJECTS
        bookSubjects.TryAdd(book.Subject, new List<Book>());
        bookSubjects[book.Subject].Add(book);
    }

    public List<Book> GetBookByTitle(string title) => bookTitles.GetValueOrDefault(title) ?? new List<Book>();
    public List<Book> GetBookByAuthor(string author) => bookAuthors.GetValueOrDefault(author) ?? new List<Book>();
    public List<Book> GetBookByPublisher(string publisher) => bookPublications.GetValueOrDefault(publisher) ?? new List<Book>();
    public List<Book> GetBookBySubject(string subject) => bookSubjects.GetValueOrDefault(subject) ?? new List<Book>();
}