namespace SecondoTest.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int ProductsCounts { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Product: {ProductsCounts}";
        }
    }
}
