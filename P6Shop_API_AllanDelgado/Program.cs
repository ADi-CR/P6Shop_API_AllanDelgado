
using Microsoft.EntityFrameworkCore;
using P6Shop_API_AllanDelgado.Models;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        //Creaci�n de la configuraci�n de cadena de conexi�n contra el entorno
        var conn = @"SERVER=.;DATABASE=P6SHOPPING;INTEGRATED SECURITY=TRUE; User Id=;Password=";
        builder.Services.AddDbContext<P6SHOPPINGContext>(options => options.UseSqlServer(conn));

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
        
        app.UseRouting();

        app.UseAuthorization();

        app.MapControllers();
               

        app.Run();
    }
}