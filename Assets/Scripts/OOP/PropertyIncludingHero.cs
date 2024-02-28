namespace MyOOP
{
    public class PropertyIncludingHero
    {
        private int health = 0;
        private readonly int maxHealth = 100;

        public bool IsAlive { get; private set; }
        public string Name { get; private set; }
        public int Health
        {
            get => health;

            set
            {
                if (value <= 0)
                {
                    IsAlive = false;
                    health = 0;
                }
                else if (value > this.maxHealth)
                {
                    health = 100;
                }
                else
                {
                    health = value;
                }
            }
        }

        public PropertyIncludingHero(string name, int initialHealth = 100, int maxHealth = 100)
        {
            IsAlive = true;
            Name = name;
            this.maxHealth = maxHealth;
            Health = initialHealth;
        }
    }

}
