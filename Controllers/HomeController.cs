using Microsoft.AspNetCore.Mvc;
using Serilog;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Log.Debug("This is a debug message.");
        Log.Information("This is an information message.");
        Log.Warning("This is a warning message.");
        Log.Error("This is an error message.");
        Log.Fatal("This is a fatal error message.");

        return View();
    }
}
