using SecondoTest.ViewModels;

namespace SecondoTestDatabaseFirst.Interfaces
{
    public interface ICategoryData
    {
        List<CategoryViewModel> GetCategories();
        Task<CategoryDetails?> GetCategoryAsync(int CategoryId);
        void UpdateCategory(CategoryUpdateViewModel Category);
        Task<int> AddCategory(CategoryCreateViewModel Category);
      //  Task<int> AddCategory(string CategoryName, string CategoryDescription);
    }
}
