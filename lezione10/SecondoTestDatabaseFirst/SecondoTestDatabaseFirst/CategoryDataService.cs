using Microsoft.EntityFrameworkCore;
using SecondoTestDatabaseFirst.Data;
using SecondoTestDatabaseFirst.Interfaces;
using SecondoTestDatabaseFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondoTestDatabaseFirst
{
    public class CategoryDataService : ICategoryData
    {
        private readonly NorthwindContext database;

        public CategoryDataService(NorthwindContext database)
        {
            this.database = database;
        }

        public List<CategoryViewModel> GetCategories()
        {
            return database.Categories.Include(x => x.Products)
                .Select(c => new CategoryViewModel
                {
                    Id = c.CategoryId,
                    Name = c.CategoryName,
                    ProductsCounts = c.Products.Count
                }).ToList();
        }

        public async Task<CategoryDetails?> GetCategoryAsync(int CategoryId)
        {
                    return  await database.Categories
                        .Select(c => new CategoryDetails
                        {
                            Id = c.CategoryId,
                            Name = c.CategoryName,
                            Products =
                                c.Products.Select(p => new ProductViewModel
                                {
                                    Id = p.ProductId,
                                    Name = p.ProductName,
                                    Supplier = p.Supplier.CompanyName,
                                    UnitPrice = p.UnitPrice,
                                    UnitsInStock = p.UnitsInStock
                                }).ToList()
                        }).FirstOrDefaultAsync(c => c.Id == CategoryId);
        }

        public void UpdateCategory(CategoryUpdateViewModel Category)
        {
            var categoryDb = database.Categories.Find(Category.Id);
            if(categoryDb != null) {
                categoryDb.CategoryName = Category.Name;
                categoryDb.Description = Category.Description;
                database.SaveChanges();
            }
        }
    }
}
