namespace OOPCharacter12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            p1.setHealth(100);
        }
    }
    class Player
    {
        private int health; // properties are set to private

        public void setHealth(int newHealth) // methods are set to public
        {
            if (newHealth > 100)
            {
                newHealth = 100;
            }
            health = newHealth;
        }
    }
}
