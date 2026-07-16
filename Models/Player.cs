namespace Hello.Models
{
 internal class Player
    {
        public string name = "Kaushal";
        private int health = 49;

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int h)
        {
            health = h;
        }
    }
}