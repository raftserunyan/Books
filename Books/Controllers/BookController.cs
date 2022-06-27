using Books.Models;
using Books.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                BookModel book = _bookService.GetById(id);
                return Ok(book);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(_bookService.GetByName(name));
        }

        [HttpGet("GetByAuthor/{author}")]
        public IActionResult GetByAuthor(string author)
        {
            return Ok(_bookService.GetByAuthor(author));
        }

        [HttpGet("GetByProductionYear/{year}")]
        public IActionResult GetByProductionYear(int year)
        {
            return Ok(_bookService.GetByProductionYear(year));
        }

        [HttpGet("GetByDescription/{description}")]
        public IActionResult GetByDescription(string description)
        {
            return Ok(_bookService.GetByDescription(description));
        }

        [HttpGet("GetByTotalCount/{totalCount}")]
        public IActionResult GetByTotalCount(int totalCount)
        {
            return Ok(_bookService.GetByTotalCount(totalCount));
        }

        [HttpGet("GetByBorrowingCount/{borrowingCount}")]
        public IActionResult GetByBorrowingCount(int borrowingCount)
        {
            return Ok(_bookService.GetByBorrowingCount(borrowingCount));
        }

        [HttpGet("GetByUsingCount/{usingPages}")]
        public IActionResult GetByUsingCount(int usingCount)
        {
            return Ok(_bookService.GetByUsingCount(usingCount));
        }

        [HttpGet("GetByGenre/{genre}")]
        public IActionResult GetByGenre(string genre)
        {
            return Ok(_bookService.GetByGenre(genre));
        }

        ///////////////////////////////////

        [HttpPost]
        public IActionResult Add(BookModel book)
        {
            try
            {
                _bookService.Add(book);

                return Ok();
            }
            catch (System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        ////////////////////////////////////////

        [HttpDelete("DeleteBookById/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            try
            {
                _bookService.DeleteBookById(id);
                return Ok();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("DeleteBookByName/{name}")]
        public IActionResult DeleteBookByName(string name)
        {
            _bookService.DeleteBookByName(name);
            return Ok();
        }

        [HttpDelete("DeleteBookByAuthor/{author}")]
        public IActionResult DeleteBookByAuthor(string author)
        {
            _bookService.DeleteBookByAuthor(author);
            return Ok();
        }

        [HttpDelete("DeleteBookByGenre/{genre}")]
        public IActionResult DeleteBookByGenre(string genre)
        {
            _bookService.DeleteBookByGenre(genre);
            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Update(BookModel book)
        {
            try
            {
                _bookService.Update(book);

                return Ok();
            }
            catch (System.Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}