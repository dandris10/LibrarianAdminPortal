using LibrarianAdminPortal.Data;
using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Models.Entities;
using LibrarianAdminPortal.Repository;

namespace LibrarianAdminPortal.Service
{
    public class LendedBookService
    {
        private readonly LendedBookRepository repository;

        public LendedBookService(LendedBookRepository repository)
        {
            this.repository = repository;
        }

        public List<LendBook> getAllLendedBooks()
        {
            return repository.getAllLendedBooks();
        }
        public LendBook lendBook(Guid id, string name)
        {
            return repository.lendBook(id, name);
        }

        public LendBook returnBook(Guid id, string name)
        {
            return repository.returnBook(id, name);
        }

    }
}
