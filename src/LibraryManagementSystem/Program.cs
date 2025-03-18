using LibraryManagementSystem;

Library lib = new Library("test", "Bangalore");
Catalog bookDatabase = new Catalog();

User person = new User("Harsh", "Daman", "harsh@gmail.com", "8758149799");
Librarian librarian = new Librarian("id", "pass", person);

Book book1 = new Book("c++", "Coding", "Dan", "TATA");
librarian.AddBook(book1, bookDatabase);

Book book2 = new Book("JAVA", "Coding", "Henry", "TATA");
librarian.AddBook(book2, bookDatabase);

List<Book> display = bookDatabase.GetBookBySubject("Coding");
foreach (Book book in display)
{
    DisplayBook(book);
    Console.WriteLine("check");
}

static void DisplayBook(Book book)
{
    Console.WriteLine("Book:");
    Console.WriteLine($"\tTitle: {book.Title}");
    Console.WriteLine($"\tSubject: {book.Subject}");
    Console.WriteLine($"\tAuthor: {book.Author}");
    Console.WriteLine($"\tPublisher: {book.Publisher}");
}