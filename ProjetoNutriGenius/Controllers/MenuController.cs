using Microsoft.AspNetCore.Mvc;

namespace ProjetoNutriGenius.Controllers;
public class MenuController : Controller
{
    public ViewResult Index()
    {
        return View();
    }
}
