using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Models.Entities;
using LibrarianAdminPortal.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LibrarianAdminPortal.Service
{
    public class BookService
    {
        private readonly IBookRepository repository;

        public BookService(IBookRepository repository)
        {
            this.repository = repository;
        }

        public List<Book> getAllBooks()
        {
            return repository.getAllBooks();
        }

        public Book addBook(AddBookDto addBookDto)
        {
            return repository.addBook(addBookDto);
        }

        public Book getBookById(Guid id)
        {
            return repository.getBookById(id);
        }

        public Book updateBook(Guid id, UpdateBookDto updateBookDto)
        {
            return repository.updateBook(id, updateBookDto);
        }

        public Book deleteBook(Guid id)
        {
            return repository.deleteBook(id);
        }

        public List<Book> getBooksByAuthor(string author)
        {
            return repository.getBooksByAuthor(author);
        }


    }
}
