namespace LibreriaDaTestare
{
    public class Player
    {
        public int Health { get; set; } = 100;
        public bool IsDead { get; private set; }
        public string Race { get; set; } = "Human";
        public int SpecificRaceDamage { get; set; } = 20;

        public void Hit(int damage)
        {
            var specificdamage = 0;
            if(Race == "Elf")
            {
                specificdamage = SpecificRaceDamage;
            }

            Health -= (damage + specificdamage);
            if(Health <= 0)
            {
                IsDead = true;
            }
        }
    }
}
