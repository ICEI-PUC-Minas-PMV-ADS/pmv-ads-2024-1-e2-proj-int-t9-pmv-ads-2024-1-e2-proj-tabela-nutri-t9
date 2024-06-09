using Microsoft.AspNetCore.Mvc;

namespace ProjetoNutriGenius.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _context.UsuarioRepository.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}
