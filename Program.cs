using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication6.Models;

var builder = WebApplication.CreateBuilder(args);



// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres"));
});

builder.Services.AddRazorPages();
var app = builder.Build();

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;


    var db = serviceProvider.GetRequiredService<ApplicationContext>();
    await db.Database.EnsureDeletedAsync();
    await db.Database.EnsureCreatedAsync();
    await ApplicationContextSeed.InitializeDb(db);

}
app.Run();