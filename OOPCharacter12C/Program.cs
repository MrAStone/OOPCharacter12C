namespace OOPCharacter12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Bob",1);
            p1.setHealth(100);
            p1.setArmour(100);
            Console.WriteLine(p1.getHealth());

        }
    }
    class Player
    {
        private int health; // properties are set to private
        private string name;
        private int armour;
        private double level;
        // name, armour, size, level
        // add method to set armour
        // add method to get all individual properties
        public Player(string charName,double startLevel) // this is the constructor which is called with new
        {
            name = charName;
            level = startLevel;

        }

        public void setHealth(int newHealth) // methods are set to public
        {
            if (newHealth > 100)
            {
                newHealth = 100;
            }
            health = newHealth;
        }
        public int getHealth()
        {
            return health;
        }
        public void setArmour(int newArmour)
        {
            if (newArmour > 100)
            {
                newArmour = 100;
            }
            else if (newArmour < 0)
            {
                newArmour = 0;
            }
        }
        public int getArmour()
        {
            return armour;
        }
        public string getName()
        {
            return name;
        }
        public double getLevel()
        {
            return level;
        }


    }
}
