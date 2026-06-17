using Identity.Infrastructure.Authentication;
using Microsoft.EntityFrameworkCore;

namespace Identity;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();
        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}
