var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddControllers();
var app = builder.Build();


// Middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
