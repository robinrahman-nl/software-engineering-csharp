public class Library

// 3.
// Let’s implement a method to add a new Book to the Library.
// add a method called AddBook that takes a Book object and adds it to the list of books.
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

// 4. 
// Next, implement a method to search for books by title.
// Create a method called SearchBooksByTitle that takes a string 
// and returns a list of books with titles matching the input.
    public List<Book> SearchBooksByTitle(string searchttitle)
    {
        List<Book> searchResult = new List<Book> {};
        foreach (Book item in books)
        {
            if (item.Title.Contains(searchttitle))
            {
                searchResult.Add(item);
            }
        }
        return searchResult;
    }

    // 5. 
    // Lastly, implement a method to display all books.
    // Create a method called DisplayAllBooks that prints out all books in the library.

    public void DisplayAllBooks ()
    {
            Console.WriteLine("****Display All Books****");
        foreach (Book item in books)
        {
            Console.WriteLine($"-\nTitle: {item.Title}\nAuthor: {item.Author} ");
        }
    }
}