using Microsoft.AspNetCore.Mvc;

namespace ProjetoNutriGenius.Controllers;
public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View();
    }
}
