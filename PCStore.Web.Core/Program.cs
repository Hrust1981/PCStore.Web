using Microsoft.EntityFrameworkCore;
using PCStore.Web.Core;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
