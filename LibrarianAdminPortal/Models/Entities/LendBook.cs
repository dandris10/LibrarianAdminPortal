namespace LibrarianAdminPortal.Models.Entities
{
    public class LendBook
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; } // Foreign key to Book
        public string BorrowerName { get; set; } = null!;
        public DateTime LendDate { get; set; }

        public Book Book { get; set; } = null!;
    }
}
