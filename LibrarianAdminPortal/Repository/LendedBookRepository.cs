using LibrarianAdminPortal.Data;
using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Models.Entities;

namespace LibrarianAdminPortal.Repository
{
    public class LendedBookRepository
    {
        private readonly ApplicationDbContext dbContext;

        public LendedBookRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<LendBook> getAllLendedBooks()
        {
            return dbContext.LendedBooks.ToList();
        }


        public LendBook lendBook(Guid id, string name)
        {
            var book = dbContext.Books.Find(id);

            if (book is null || book.CurrentQuantity <= 0)
                return null;

            book.CurrentQuantity = book.CurrentQuantity - 1;

            var lendedBook = new LendBook()
            {
                Id = Guid.NewGuid(),
                BookId = book.Id,
                BorrowerName = name,
                LendDate = DateTime.UtcNow
            };

            dbContext.LendedBooks.Add(lendedBook);
            dbContext.SaveChanges();

            return lendedBook;
        }

        public LendBook returnBook(Guid id, string name)
        {
            var originalBook = dbContext.Books.Find(id);
            var bookToBeDeleted = dbContext.LendedBooks.FirstOrDefault(b => b.BookId == id && b.BorrowerName == name);

            dbContext.LendedBooks.Remove(bookToBeDeleted);
            originalBook.CurrentQuantity = originalBook.CurrentQuantity + 1;
            dbContext.SaveChanges();

            return bookToBeDeleted;
            
        }
    }
}
