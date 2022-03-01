using Microsoft.EntityFrameworkCore;
using SecondoTest.ViewModels;
using SecondoTestDatabaseFirst;
using SecondoTestDatabaseFirst.Data;
using SecondoTestDatabaseFirst.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Northwind");

builder.Services.AddDbContext<NorthwindContext>(
    opzioni => opzioni.UseSqlServer(connectionString));
builder.Services.AddScoped<ICategoryData, CategoryDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/categories",  (ICategoryData service) => { return service.GetCategories(); });
app.MapGet("/category/details/{id}", async (ICategoryData service, int id) =>
{ return await service.GetCategoryAsync(id);});
app.MapPut("/category/{id}", (ICategoryData service, int id, CategoryUpdateViewModel category) =>
{  service.UpdateCategory(category);
    return Results.NoContent();
});
app.MapPost("/category", async (ICategoryData service, CategoryCreateViewModel category) =>
 {
     return await service.AddCategory(category);
 });

app.Run();

