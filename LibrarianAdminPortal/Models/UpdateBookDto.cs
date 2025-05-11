namespace LibrarianAdminPortal.Models
{
    public class UpdateBookDto
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int? Quantity { get; set; }

        public int? CurrentQuantity { get; set; }
    }
}
