namespace Hello.Examples;

internal static class StringsExample
{
    public static void Run()
    {
        const string language = "C# is expressive";
        Console.WriteLine(language.ToUpperInvariant());
        Console.WriteLine($"Length: {language.Length}");
        Console.WriteLine($"Contains 'expressive': {language.Contains("expressive")}");
    }
}
