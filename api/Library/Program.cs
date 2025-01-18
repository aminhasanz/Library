using Dapper;
using Microsoft.Data.SqlClient;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connection = new SqlConnection(connectionString);
        }
    }
}
