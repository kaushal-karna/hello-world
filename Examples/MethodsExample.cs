namespace Hello.Examples;

internal static class MethodsExample
{
    public static void Run()
    {
        Console.WriteLine($"Average: {Average(8, 6, 10):0.0}");
        Greet("C# learner");
    }

    private static double Average(params int[] values) => values.Average();

    private static void Greet(string name) => Console.WriteLine($"Hello, {name}!");
}
