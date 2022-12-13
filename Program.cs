using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using labBD.Models;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres"));
});

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

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