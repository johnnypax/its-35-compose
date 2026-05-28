using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseDocker")));

builder.Services.AddScoped<PostService>();
builder.Services.AddScoped<PostRepository>();

builder.Services.AddScoped<CommentoService>();
builder.Services.AddScoped<CommentoRepository>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
