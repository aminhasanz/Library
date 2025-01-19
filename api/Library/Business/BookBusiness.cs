using Library.Data;
using Library.Model;
using Library.Model.Book;
using Library.Model.Table;

namespace Library.Business
{
    public class BookBusiness
    {
        private BookData bookData;

        public BookBusiness()
        {
        }

        public BookBusiness(BookData bookData) 
        {
            this.bookData = bookData;
        }
        public BusinessResult<int> AddBusiness(BookModel model)
        {
            BusinessResult<int> result = new();
            
            BookTable book = new()
            {
                Title = model.Title,
                Author = model.Author,
                Pages = model.Pages
            };

            result.Data = this.bookData.Insert(book);
            result.Success = true;

            return result;
        }

        public BusinessResult<BookTable> GetBookBusiness(int bookId)
        {
            BookTable book = this.bookData.GetBook(bookId);
            return new()
            {
                Success = true,
                Data = book
            };
        }

        public BusinessResult<IEnumerable<BookTable>> GetBooksBusiness()
        {
            return new()
            {
                Success = true,
                Data = this.bookData.GetBooks()
            };
        }
    }
}
