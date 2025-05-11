using LibrarianAdminPortal.Data;
using LibrarianAdminPortal.Models;
using LibrarianAdminPortal.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibrarianAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService service;

        public BooksController(BookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult getAllBooks()
        {
            return Ok(service.getAllBooks());
        }

        [HttpPost]
        public IActionResult addBook(AddBookDto addBookDto)
        {
            return Ok(service.addBook(addBookDto));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult getBookById(Guid id)
        {
            var book = service.getBookById(id);
            if(book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }


        [HttpPut]
        [Route("{id:guid}")]

        public IActionResult updateBook(Guid id, UpdateBookDto updateBookDto)
        {
            var book = service.updateBook(id, updateBookDto);
            if (book is null)
                return NotFound();

            return Ok(book);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult deleteBook(Guid id)
        {
            var book = service.deleteBook(id);
            if (book is null)
                return NotFound();

            return Ok(book);
        }

        [HttpGet("{author}")]
        public IActionResult getBooksByAuthor(string author)
        {
            var books = service.getBooksByAuthor(author);
            return Ok(books);
        }


    }
}
