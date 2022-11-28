using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FigureDbContext>
    (options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("FigureDbContext")));
var app = builder.Build();
//x => x.MigrationsAssembly("FigureDbContext")
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
