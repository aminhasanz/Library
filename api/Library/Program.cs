using Library.Business;
using Library.Data;
using Library.Model.Book;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseCors(x=>
            {
                x.AllowAnyHeader();
                x.AllowAnyOrigin();
                x.AllowAnyMethod();
            });

            app.UseAuthorization();

            app.UseRouting();

            app.MapControllers();


            app.Run();
        }
    }
}
