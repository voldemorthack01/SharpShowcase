using Figgle.Fonts;

namespace SharpShowcase.Demos;

public static class FiggleDemo
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Figgle (ASCII Art) Demo");
        Console.WriteLine("-----------------------");
        
        Console.WriteLine("Enter text to convert to ASCII art (default: Hello World):");
        string? input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            input = "Hello World";
        }

        Console.WriteLine(FiggleFonts.Standard.Render(input));
        Console.WriteLine("\nPress any key to return...");
        Console.ReadKey();
    }
}
