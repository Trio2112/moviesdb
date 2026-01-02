using Microsoft.EntityFrameworkCore;
using moviesdb.api.Entities;
using moviesdb.api.Repositories.Implementations;
using moviesdb.api.Repositories.Interfaces;

namespace moviesdb.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Enable IIS integration
            builder.WebHost.UseIIS();

            // Add services to the container.
            builder.Services.AddControllers();

            // AutoMapper
            builder.Services.AddAutoMapper(typeof(Program));

            // Entity Framework Core: register DbContext (SQL Server Express)
            var connectionString = builder.Configuration.GetConnectionString("MoviesDb")
                                   ?? "Server=localhost\\SQLEXPRESS;Database=MoviesDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.Services.AddDbContext<MoviesDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Register repositories
            builder.Services.AddScoped<IMovieRepository, MovieRepository>();
            builder.Services.AddScoped<IActorRepository, ActorRepository>();
            builder.Services.AddScoped<IMovieActorRepository, MovieActorRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
