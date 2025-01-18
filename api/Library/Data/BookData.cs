using Dapper;
using Library.Model.Book;
using Library.Model.Table;
using Microsoft.Data.SqlClient;

namespace Library.Data
{
    public class BookData
    {
        private SqlConnection db;

        public BookData()
        {
            string connectionString = "Data Source=.;Database=Library;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            this.db = new(connectionString);
        }
        public int Insert(BookTable table)
        {

            string sql = "INSERT INTO Book (Title, Author, Pages) OUTPUT INSERTED.Id VALUES (@Title, @Author, @Pages)";

            int id = db.ExecuteScalar<int>(sql, table);

            return id;
        }

        public IEnumerable<BookTable> GetBooks()
        {
            string sql = "SELECT * FROM Book";
            return db.Query<BookTable>(sql);
        }

        public BookTable GetBook(int id)
        {
            string sql = $"SELECT * FROM Book WHERE Id = @Id";

            return this.db.QuerySingle<BookTable>(sql, new { Id = id });
        }
    }
}
