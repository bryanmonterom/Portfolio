using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository repo;

    public HomeController(ILogger<HomeController> logger, IRepository repo)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var projects = repo.GetProjects();
        var model = new PortfolioViewModel(){Projects = projects };
        return View("Index",model);
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
