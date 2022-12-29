using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IRepository _repository;
    private readonly IEmailSendGrid emailService;

    public HomeController(IRepository repo, IEmailSendGrid emailService)
    {
        _repository = repo;
        this.emailService = emailService;
    }

    public IActionResult Index()
    {
        var projects = _repository.GetProjects();
        var skills = _repository.GetSkills();

        var model = new PortfolioViewModel(){Projects = projects, Skills = skills };
        return View("Index",model);
    }

    public IActionResult Contact() { 
    
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Contact(ContactViewModel contact)
    {
        await emailService.SendEmailAsync(contact); 
        return RedirectToAction("Thanks", "Home");
    }

    public IActionResult Thanks() {
        return View("Thanks");
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
