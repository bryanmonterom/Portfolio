using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IRepository _repository;

    public HomeController(IRepository repo)
    {
        _repository = repo; 
    }

    public IActionResult Index()
    {
        var projects = _repository.GetProjects();
        var model = new PortfolioViewModel(){Projects = projects };
        return View("Index",model);
    }


    public IActionResult Projects() { 
        var projects = _repository.GetProjects();
        return View(projects);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
