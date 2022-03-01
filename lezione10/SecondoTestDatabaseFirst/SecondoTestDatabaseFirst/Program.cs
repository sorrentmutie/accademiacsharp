// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using SecondoTestDatabaseFirst;
using SecondoTestDatabaseFirst.Data;
using SecondoTestDatabaseFirst.Interfaces;
using SecondoTestDatabaseFirst.ViewModels;

Console.WriteLine("Hello, World!");

var database = new NorthwindContext();
ICategoryData dataService = new CategoryDataService(database);



//var categories = database.Categories.Include(x => x.Products)
//    .Select(c => new CategoryViewModel { Id = c.CategoryId, Name = c.CategoryName,
//     ProductsCounts = c.Products.Count}).ToList();

var categories = dataService.GetCategories();
foreach (var category in categories)
{
    Console.WriteLine(category);
}

// estrazione categoria 1
var id = 1;
var firstcategory = await dataService.GetCategoryAsync(id);

//var firstcategory = await database.Categories
//    .Select(c => new CategoryDetails
//    {
//        Id = c.CategoryId, Name = c.CategoryName, Products = 
//            c.Products.Select(p => new ProductViewModel
//            {
//                Id = p.ProductId,
//                Name = p.ProductName,
//                Supplier = p.Supplier.CompanyName,
//                UnitPrice = p.UnitPrice,
//                UnitsInStock = p.UnitsInStock
//            }).ToList()
//    }).FirstOrDefaultAsync(c=> c.Id == id);

Console.WriteLine(firstcategory?.Name);
if(firstcategory?.Products != null)
{
    foreach (var product in firstcategory.Products)
    {
        Console.WriteLine($"{product?.Name} {product?.Supplier} {product?.UnitPrice}");
    }
}

// firstcategory.
//var firstcategoryDb = await database.Categories.FindAsync(1);

var updateCategory = new CategoryUpdateViewModel
{
    Id = 1,
    Description = "???",
    Name = "NuovoNome"
};

dataService.UpdateCategory(updateCategory);

//firstcategoryDb.CategoryName += "!!!";
//firstcategoryDb.Description = "categoria bellissima";
//await database.SaveChangesAsync();



// .ThenInclude(p => p.Supplier);

// Console.WriteLine(categories.Count());



