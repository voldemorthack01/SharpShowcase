using SharpShowcase.Demos;
using Serilog;

namespace SharpShowcase.Menu;

public static class InteractiveMenu
{
    public static void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("SharpShowcase - Main Menu");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Run Figgle Demo (ASCII Art)");
            Console.WriteLine("2. Run Humanizer Demo");
            Console.WriteLine("3. Run Logging Demo");
            Console.WriteLine("Q. Quit");
            Console.WriteLine();
            Console.Write("Select an option: ");

            var key = Console.ReadKey().Key;

            try
            {
                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Log.Information("User selected Figgle Demo");
                        FiggleDemo.Run();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Log.Information("User selected Humanizer Demo");
                        HumanizerDemo.Run();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Log.Information("User selected Logging Demo");
                        LoggingDemo.Run();
                        break;
                    case ConsoleKey.Q:
                        Log.Information("User selected Quit");
                        return;
                    default:
                        // Ignore invalid input
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error running menu option");
                Console.WriteLine("\nAn error occurred. Check logs for details.");
                Console.WriteLine("Press key to continue...");
                Console.ReadKey();
            }
        }
    }
}
