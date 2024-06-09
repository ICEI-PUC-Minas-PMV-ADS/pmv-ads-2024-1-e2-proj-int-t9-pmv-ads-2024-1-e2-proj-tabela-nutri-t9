<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;

namespace ProjetoNutriGenius.Controllers;
public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View();
    }
=======
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoNutriGenius.Models;

namespace ProjetoNutriGenius.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
>>>>>>> 41b1dab8af167fed35ea28bbe869a3cdb8dc717b
}
