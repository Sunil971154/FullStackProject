
using Microsoft.EntityFrameworkCore;
using Revision_Project.Data;
using Revision_Project.Interface;
using Revision_Project.ServiceIMPL;

namespace Revision_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));// connection string app setting me bana lo 


            // Register the UserServiceImpl as IUserRepository
            builder.Services.AddScoped<IUserRepository, UserServiceImpl>();
            builder.Services.AddScoped<IJERepository, JournalEntryServiceImpl>();
            


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            

            Console.WriteLine(" Program Started Now ");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
