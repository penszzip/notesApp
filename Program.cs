using Microsoft.EntityFrameworkCore;
using notesApp.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Azure SQL Connection
var connection = String.Empty;
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
    connection = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
}
else
{
    connection = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTIONSTRING");
}
builder.Services.AddDbContext<NoteDbContext>(options =>
    options.UseSqlServer(connection));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//configure CORS
//define a unique string
string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// define allowed domains, in this case "http://example.com" and "*" = all
//    domains, for testing purposes only.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
      builder =>
      {
        //   builder.WithOrigins(
        //     "http://localhost:5173");
        builder.AllowAnyOrigin();
      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
