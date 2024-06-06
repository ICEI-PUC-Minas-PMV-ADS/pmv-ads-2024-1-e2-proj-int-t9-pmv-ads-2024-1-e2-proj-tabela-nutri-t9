using Microsoft.AspNetCore.Mvc;

namespace ProjetoNutriGenius.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public IActionResult Create()
        // {
        //     return View();
        // }

        // [HttpPost]
        // public async Task<IActionResult> Create(UsuarioModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.UsuarioRepository.Add(model);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction("Home"); // Redirecionar para a página inicial ou outra página após o cadastro
        //     }
        //     return View(model);
        // }
    }
}