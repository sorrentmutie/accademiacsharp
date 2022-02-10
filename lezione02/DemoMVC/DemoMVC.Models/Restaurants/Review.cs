namespace DemoMVC.Models.Restaurants
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ReviewerId { get; set; }
        public int Rating { get; set; }
    }
}