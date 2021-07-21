using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1911061972_NguyenBinhAn_Lab7.Models;
namespace _1911061972_NguyenBinhAn_Lab7.Controllers
{
    public class BookController : ApiController
    {
        public List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "The Lord Of The Ring",
                Content = "The Lord Of The Ring",
                Author = "J.R.R Tolkien",
                Price = 99
            },
            new Book
            {
                Id = 2,
                Title = "The Secret Of The Sword",
                Content = "The Secret Of the Sword",
                Author = "J.R.R Tolkien",
                Price = 69
            }
        };

        public List<Book> GetBooks()
        {
            return books;
        }

        public IHttpActionResult GetBookById(int Id)
        {
            var book = books.FirstOrDefault(b =>b.Id == Id);
            if (book == null) return NotFound();
            return Ok(book);
        }
    }
}
    

