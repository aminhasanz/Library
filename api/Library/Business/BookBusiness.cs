using Library.Data;
using Library.Model;
using Library.Model.Book;
using Library.Model.Table;

namespace Library.Business
{
    public class BookBusiness
    {
        public BusinessResult<int> Add(BookAddModel model)
        {
            BusinessResult<int> result = new();
            
            BookTable book = new()
            {
                Title = model.Title,
                Author = model.Author,
                Pages = model.Pages
            };

            result.Data = new BookData().Insert(book);
            result.Success = true;

            return result;
        }
    }
}
