

using SecondoTestDatabaseFirst.ViewModels;

namespace SecondoTestDatabaseFirst.Interfaces
{
    public interface ICategoryData
    {
        List<CategoryViewModel> GetCategories();
        Task<CategoryDetails?> GetCategoryAsync(int CategoryId);
        void UpdateCategory(CategoryUpdateViewModel Category);
    }
}
