
using Microsoft.Data.SqlClient;
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

        //Obtenemos la info de la cadena de conexión desde el archivo de configuración
        //appsettings.json. el nombre de la etiqueta es CNNSTR
        var CnnStrBuilder = new SqlConnectionStringBuilder( 
            builder.Configuration.GetConnectionString("CNNSTR"));

        string conn = CnnStrBuilder.ConnectionString;

                
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