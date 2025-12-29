using SharpShowcase.Configuration;
using SharpShowcase.Menu;
using Serilog;

try
{
    // Initialize Logging
    LoggingSetup.ConfigureLogging();
    Log.Information("Application Starting Up...");

    // Run Menu
    InteractiveMenu.Show();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
}
finally
{
    Log.Information("Application Shutting Down...");
    await Log.CloseAndFlushAsync();
}