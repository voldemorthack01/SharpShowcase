using Figgle.Fonts;
using Humanizer;
using Serilog;


Console.WriteLine(
    FiggleFonts.Standard.Render("Hello, World!"));


//DateTimeOffset someDate = DateTimeOffset.UtcNow.AddHours(-2);
//Console.WriteLine(someDate.Humanize()); // Output: "2 hours ago"

Console.WriteLine(DateTimeOffset.UtcNow.AddHours(-2).Humanize()); // Output: "2 hours ago"

TimeSpan duration = TimeSpan.FromDays(5);
Console.WriteLine(duration.Humanize()); // Output: "5 days"

Console.WriteLine("person".Pluralize()); // Output: "people"
Console.WriteLine("geese".Singularize()); // Output: "goose"

Console.WriteLine(1.Ordinalize()); // Output: "1st"
Console.WriteLine(2.Ordinalize()); // Output: "2nd"

Console.WriteLine("some text".Transform(To.TitleCase)); // Output: "Some Text"

Console.WriteLine("Long text to truncate".Truncate(10)); // Output: "Long text…"


//using var log = new LoggerConfiguration()
//    .WriteTo.Console()
//    .WriteTo.File("log.txt")
//    .CreateLogger();

//log.Information("Hello, Serilog!");


//var position = new { Latitude = 25, Longitude = 134 };
//var elapsedMs = 34;

//log.Information("Processed {@Position} in {Elapsed} ms", position, elapsedMs);



//Log.Logger = new LoggerConfiguration()
//    .WriteTo.Console()
//    .WriteTo.File("log.txt",
//        rollingInterval: RollingInterval.Day,
//        rollOnFileSizeLimit: true)
//    .CreateLogger();

try
{
    // Your program here...
    const string name = "Serilog";
    Log.Information("Hello, {Name}!", name);
    throw new InvalidOperationException("Oops...");
}
catch (Exception ex)
{
    Log.Error(ex, "Unhandled exception");
}
finally
{
    await Log.CloseAndFlushAsync(); // ensure all logs written before app exits
}