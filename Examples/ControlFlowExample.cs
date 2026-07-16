namespace Hello.Examples;

internal static class ControlFlowExample
{
    public static void Run()
    {
        int score = 78;
        string result = score >= 50 ? "passed" : "needs another attempt";
        Console.WriteLine($"Score {score}: {result}.");

        Console.Write("Counting with a for loop: ");
        for (int number = 1; number <= 3; number++)
        {
            Console.Write(number == 3 ? $"{number}\n" : $"{number}, ");
        }
    }
}
