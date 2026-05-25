using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseDocker")));

builder.Services.AddScoped<PostService>();

var app = builder.Build();

app.MapControllers();

app.Run();
