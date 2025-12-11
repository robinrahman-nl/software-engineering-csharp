/*
Cyber Library Management System
You are tasked with creating a library management system to manage books in your local library. You’ll be managing a collection of books where each book has a title and an author. Users should be able to add new books, search for books by title, and view all available books. Let’s dive into building this system step-by-step.

Tasks
0/9 complete
Mark the tasks as complete by checking them off
Setting Up the Foundation
1.
Create a file called Book.cs.

Inside, define the Book class with two properties:

Title of type string
Author of type string
2.
Next, create a file called Library.cs.

Inside, define a Library class that contains a private list of Book objects called books. Initialize the books list as an empty list of Book objects.

Implementing Functionality
3.
Let’s implement a method to add a new Book to the Library.

Still in Library.cs, add a method called AddBook that takes a Book object and adds it to the list of books.

4.
Next, implement a method to search for books by title.

Create a method called SearchBooksByTitle that takes a string and returns a list of books with titles matching the input.

5.
Lastly, implement a method to display all books.

Create a method called DisplayAllBooks that prints out all books in the library.

Setting Up the Library
6.
Navigate to Program.cs.

In Main(), create an instance of the Library class called library.

7.
Let’s add some books to the library object.

Create two books with the following data:

A book with the Title of "1984" and Author of "George Orwell"
A book with the Title of "To Kill a Mockingbird" and Author of "Harper Lee"
Then, add both books to the library.

8.
Let’s see if we can find a book.

Find a book with the title "1984" in the library and store the result in a variable called results.

Iterate through each element in results to print the book’s Title and Author to the console.

9.
Lastly, print the Title and Author of all the books in the library.
*/

using System;
using System.Collections.Generic;

namespace LibraryManagementSystem{
  class Program {
    static void Main() {

        Book book1 = new Book ("1984", "George Orwell");
        Book book2 = new Book ("To Kill a Mockingbird", "Harper Lee");
        

      // Initialize library

      Library libraryRotterdam = new Library();



      // Add some sample books
        libraryRotterdam.AddBook(book1);
        libraryRotterdam.AddBook(book2);

      // Search for a book
        List<Book> results = libraryRotterdam.SearchBooksByTitle("1984");
        foreach (Book item in results)
        {
            Console.WriteLine($"-\nTitle: {item.Title}\nAuthor {item.Author}");
        }
        

      // Display all books

        libraryRotterdam.DisplayAllBooks();
    }
  }
}
