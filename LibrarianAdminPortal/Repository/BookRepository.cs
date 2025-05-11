using LibrarianAdminPortal.Data;
using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LibrarianAdminPortal.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext dbContext;

        public BookRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Book> getAllBooks()
        {
            return dbContext.Books.ToList();
        }

        public Book addBook(AddBookDto addBookDto)
        {
            var book = new Book()
            {
                Title = addBookDto.Title,
                Author = addBookDto.Author,
                Quantity = addBookDto.Quantity,
                CurrentQuantity = addBookDto.CurrentQuantity
            };

            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            return book;

        }

        public Book getBookById(Guid id)
        {
            var book = dbContext.Books.Find(id);
            return book;
        }

        public Book updateBook(Guid id, UpdateBookDto updateBookDto)
        {
            var book = dbContext.Books.Find(id);

            if (updateBookDto.Author != null && book != null)
                book.Author = updateBookDto.Author;

            if (updateBookDto.Title != null && book != null)
                book.Title = updateBookDto.Title;

            if(updateBookDto.Quantity != null && book != null)
                book.Quantity = (int)updateBookDto.Quantity;

            if (updateBookDto.CurrentQuantity != null && book != null)
                book.CurrentQuantity = (int)updateBookDto.CurrentQuantity;

            dbContext.SaveChanges();

            return book;

        }

        public Book deleteBook(Guid id)
        {
            var book = dbContext.Books.Find(id);
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();

            return book;
        }

        public List<Book> getBooksByAuthor(string author)
        {
            var books = dbContext.Books.Where(b=> b.Author.ToLower() == author.ToLower()).ToList();

            return books;
        }

     
    }
}
