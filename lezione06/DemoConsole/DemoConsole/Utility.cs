namespace DemoConsole
{
    public  class Utility
    {
        public Restaurant Restaurant { get; set; } = new Restaurant();



        public Utility()
        {
            var lista = new List<Restaurant>();
            var x = lista.FirstOrDefault(x => x.Id == 1);
        }
    }
}
