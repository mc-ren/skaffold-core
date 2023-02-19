using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnetapp.Models;
using Bogus;

namespace aspnetapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var faker = new Faker();

        var fname = faker.Person.FirstName;
        var lname = faker.Person.LastName;
        var human = new Man($"Hi! I am {fname} {lname}");
        ViewBag.Msg = human;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
