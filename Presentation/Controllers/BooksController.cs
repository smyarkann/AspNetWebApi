﻿using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        //RepositoryConteti newliyoruz aslında burada 
        private readonly IServiceManager _manager;
        public BooksController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
                var books = _manager.BookService.GetAllBooks(false);
                return Ok(books);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
        {
                var book = _manager.BookService.GetOneBookById(id, false);

                return Ok(book);
        }
        [HttpPost]
        public IActionResult CreateOneBook([FromBody] Book book)
        {
                if (book is null)
                {
                    return BadRequest();
                }
                _manager.BookService.CreateOneBook(book);
                return StatusCode(201, book);

        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] Book book)
        {

                if (book is null)
                {
                    return BadRequest();
                }
                _manager.BookService.UpdateOneBook(id, book, true);
                return NoContent();

        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBooks([FromRoute(Name = "id")] int id)
        {
        
                //Service de bu kontrol var zaten
                //var entity = _manager.BookService.GetOneBookById(id, false);
                //if( entity is null)
                //{
                //    return NotFound(
                //        new { statusCode = 404, message="Kitap bulunamadı" }
                //        );                            
                //}
                _manager.BookService.DeleteOneBook(id, false);

                return NoContent();                                       
        }                                                                                                 
    }
}
