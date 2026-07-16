using Hello.Examples;

namespace Hello;

/// <summary>Entry point for the C# learning examples.</summary>
internal static class Program
{
    private static readonly IReadOnlyDictionary<string, Action> Topics =
        new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase)
        {
            ["basics"] = BasicsExample.Run,
            ["control-flow"] = ControlFlowExample.Run,
            ["methods"] = MethodsExample.Run,
            ["strings"] = StringsExample.Run,
            ["collections"] = CollectionsExample.Run,
            ["oop"] = ObjectOrientedProgrammingExample.Run,
            ["exceptions"] = ExceptionHandlingExample.Run
        };

    private static void Main(string[] args)
    {
        if (args.Length == 0 || args[0] is "--list" or "-l")
        {
            PrintTopics();
            return;
        }

        if (args[0] is "--all" or "-a")
        {
            foreach (var topic in Topics)
            {
                PrintHeading(topic.Key);
                topic.Value();
            }

            return;
        }

        if (Topics.TryGetValue(args[0], out var example))
        {
            PrintHeading(args[0]);
            example();
            return;
        }

        Console.WriteLine($"Unknown topic: {args[0]}");
        PrintTopics();
    }

    private static void PrintTopics()
    {
        Console.WriteLine("C# Learning Examples");
        Console.WriteLine("Usage: dotnet run -- <topic>");
        Console.WriteLine("\nAvailable topics:");

        foreach (var topic in Topics.Keys)
        {
            Console.WriteLine($"  {topic}");
        }

        Console.WriteLine("\nUse --all to run every example. See docs/TOPICS.md for the full index.");
    }

    private static void PrintHeading(string topic) =>
        Console.WriteLine($"\n--- {topic.ToUpperInvariant()} ---");
}
