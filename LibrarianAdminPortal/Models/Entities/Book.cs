namespace LibrarianAdminPortal.Models.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required int Quantity { get; set; }
        public required int CurrentQuantity { get; set; }

    }
}
