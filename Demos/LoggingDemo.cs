using Serilog;

namespace SharpShowcase.Demos;

public static class LoggingDemo
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Structured Logging Demo (Serilog)");
        Console.WriteLine("---------------------------------");
        
        Log.Information("This is an information message.");
        Log.Warning("This is a warning message.");
        Log.Error("This is an error message.");

        var user = new { Name = "Alice", Id = 101, Role = "Admin" };
        Log.Information("Processing user {@User}", user);

        try
        {
            throw new InvalidOperationException("Something went wrong!");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Caught an exception during demo");
        }

        Console.WriteLine("\nLogs have been written to console and file.");
        Console.WriteLine("Press any key to return...");
        Console.ReadKey();
    }
}
