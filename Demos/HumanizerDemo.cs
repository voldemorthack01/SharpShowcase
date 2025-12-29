using Humanizer;

namespace SharpShowcase.Demos;

public static class HumanizerDemo
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Humanizer Demo");
        Console.WriteLine("--------------");

        // Date/Time
        Console.WriteLine($"Check it out: {DateTimeOffset.UtcNow.AddHours(-2).Humanize()}");
        Console.WriteLine($"And this: {DateTimeOffset.UtcNow.AddHours(25).Humanize()}");
        
        // TimeSpan
        Console.WriteLine($"TimeSpan.FromDays(2): {TimeSpan.FromDays(2).Humanize()}");

        // Pluralization
        Console.WriteLine($"'Man' pluralized: {"Man".Pluralize()}");
        Console.WriteLine($"'Octopus' pluralized: {"Octopus".Pluralize()}");

        // Numbers
        Console.WriteLine($"123 to words: {123.ToWords()}");
        Console.WriteLine($"1.Ordinalize: {1.Ordinalize()}");

        // Truncate
        string longText = "This is a very long text that needs to be truncated because it is too long.";
        Console.WriteLine($"Original: {longText}");
        Console.WriteLine($"Truncated (10 chars): {longText.Truncate(10)}");

        Console.WriteLine("\nPress any key to return...");
        Console.ReadKey();
    }
}
