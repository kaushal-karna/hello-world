namespace Hello.Examples;

internal static class CollectionsExample
{
    public static void Run()
    {
        var topics = new List<string> { "Variables", "Loops", "Classes" };
        topics.Add("Collections");

        Console.WriteLine("Topics: " + string.Join(", ", topics));
        Console.WriteLine($"First topic: {topics[0]}");
    }
}
