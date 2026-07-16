namespace Hello.Examples;

internal static class ExceptionHandlingExample
{
    public static void Run()
    {
        const string input = "not a number";

        if (int.TryParse(input, out int value))
        {
            Console.WriteLine($"Parsed value: {value}");
        }
        else
        {
            Console.WriteLine($"'{input}' cannot be converted to an integer.");
        }
    }
}
