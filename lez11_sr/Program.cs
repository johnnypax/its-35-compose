using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseDocker")));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
