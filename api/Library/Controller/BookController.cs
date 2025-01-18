using Library.Business;
using Library.Model;
using Library.Model.Book;
using Library.Model.Table;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controller
{
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookBusiness bookBusiness;
        public BookController(BookBusiness bookBusiness)
        {
            this.bookBusiness = bookBusiness;
        }
        

        [HttpPost("add")]
        public BusinessResult<int> Add(BookModel model)
        {
            return this.bookBusiness.AddBusiness(model);
        }

        /*[HttpGet("getbook")]
        public BusinessResult<BookTable> GetBook(int request)
        {
            int bookId = int.Parse(Book.Id.Name);

        return bookBusiness.GetBookBusiness(bookId);
        }*/

        [HttpGet("getbooks")]
        public BusinessResult<IEnumerable<BookTable>> GetBooks()
        {
            return bookBusiness.GetBooksBusiness();
        }

    }
}
