using Library.Business;
using Library.Data;
using Library.Model.Book;
using Microsoft.Data.SqlClient;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();

            string cs = builder.Configuration.GetSection("Connection").Value;
            builder.Services.AddTransient<SqlConnection>(x => new SqlConnection(cs));

            builder.Services.AddTransient<BookBusiness>();
            builder.Services.AddTransient<BookData>();

            var app = builder.Build();

            app.UseCors(x=>
            {
                x.AllowAnyHeader();
                x.AllowAnyOrigin();
                x.AllowAnyMethod();
            });

            app.UseAuthorization();


            app.MapControllers();


            app.Run();
        }
    }
}
