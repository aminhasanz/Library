using Dapper;
using Library.Model.Table;
using Microsoft.Data.SqlClient;

namespace Library.Data
{
    public class BookData
    {
        public int Insert(BookTable table)
        {
            string connectionString = "Data Source=.;Database=Library;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection db = new(connectionString);
            db.Open();

            string sql = "INSERT INTO Book (Title, Author, Pages) OUTPUT INSERTED.Id VALUES (@Title, @Author, @Pages)";

            int id = db.ExecuteScalar<int>(sql, table);
            db.Close();

            return id;
        }
    }
}
