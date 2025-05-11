using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibrarianAdminPortal.Repository
{
    public interface IBookRepository
    {
        List<Book> getAllBooks();
        Book addBook(AddBookDto addBookDto);
        Book getBookById(Guid id);
        Book updateBook(Guid id, UpdateBookDto updateBookDto);
        Book deleteBook(Guid id);
        List<Book> getBooksByAuthor(string author);

    }
}
