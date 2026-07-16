namespace Hello.Examples;

internal static class BasicsExample
{
    public static void Run()
    {
        string name = "Ada";
        int completedLessons = 4;
        double progress = 87.5;
        bool isLearning = true;

        Console.WriteLine($"{name} has completed {completedLessons} lessons.");
        Console.WriteLine($"Progress: {progress}% | Learning: {isLearning}");
        Console.WriteLine($"Next lesson: {completedLessons + 1}");
    }
}
