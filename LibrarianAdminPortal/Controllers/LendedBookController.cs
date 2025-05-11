using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Service;
using Microsoft.AspNetCore.Mvc;
using LibrarianAdminPortal.Models.Entities;

namespace LibrarianAdminPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LendedBooksController : ControllerBase
    {
        private readonly LendedBookService service;

        public LendedBooksController(LendedBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<LendBook> getAllLendedBooks()
        {
            return service.getAllLendedBooks();
        }

        [HttpPost("lend/{id:guid}")]
        public IActionResult lendBook(Guid id, [FromQuery] string borrower)
        {
            var book = service.lendBook(id, borrower);

            if (book is null)
                return BadRequest("Book not available");

            return Ok(book);
        }

        [HttpDelete("return/{id:guid}")]
        public IActionResult returnBook(Guid id, [FromQuery] string borrower)
        {
            var book = service.returnBook(id, borrower);
            if (book is null)
                return BadRequest("Book not available");

            return Ok(book);
        }


    }

}
