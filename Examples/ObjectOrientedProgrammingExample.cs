using Hello.Models;

namespace Hello.Examples;

internal static class ObjectOrientedProgrammingExample
{
    public static void Run()
    {
        var player = new Player("Avery");
        player.TakeDamage(25);

        Console.WriteLine($"{player.Name}'s health: {player.Health}");
    }
}
