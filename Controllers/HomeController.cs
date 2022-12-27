using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View();
    }

    private List<Project> GetProjects(){
        return new List<Project>() {
            new Project{Title="Amazon",Description="E-Commerce con NetCore",Link="amazon.com"},
            new Project{Title="Facebook",Description="Social network called Instagram",Link="instagram.com"},
            new Project{Title="Google",Description="Search engine called Google",Link="Google.com"},
            new Project{Title="Stackoverflow",Description="Forum to help developers",Link="Stackoverflow.com"},
        };
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
