namespace SecondoTest.ViewModels
{
    public class CategoryUpdateViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class CategoryCreateViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<ProductCreateViewModel> Products { get; set; } = new List<ProductCreateViewModel>();
    }

}