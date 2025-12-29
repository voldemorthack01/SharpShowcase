using Serilog;

namespace SharpShowcase.Configuration;

public static class LoggingSetup
{
    public static void ConfigureLogging()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/app_log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }
}
