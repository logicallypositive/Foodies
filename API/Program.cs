using Application.Foods;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);


//    Services    //


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

// Data Context
builder.Services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// CORS
builder.Services.AddCors(opt => 
{
    opt.AddPolicy("CorsPolicy", policy => 
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
    });
});

// MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly));

var app = builder.Build();


//    Middleware    //


app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.SeedData(context);

}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}

app.Run();
