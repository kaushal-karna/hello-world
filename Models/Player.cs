namespace Hello.Models;

/// <summary>A small class used by the object-oriented programming example.</summary>
internal sealed class Player
{
    public string Name { get; }
    public int Health { get; private set; }

    public Player(string name, int health = 100)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int amount) => Health = Math.Max(0, Health - amount);
}
