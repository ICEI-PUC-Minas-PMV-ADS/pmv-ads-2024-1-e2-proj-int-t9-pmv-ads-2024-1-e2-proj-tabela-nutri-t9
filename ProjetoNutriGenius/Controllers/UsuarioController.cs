using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.UsuarioRepository.Add(model);
                    await _context.SaveChangesAsync();
                    return Ok(); // Redirecionar para a página inicial ou outra página após o cadastro
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao inserir registro: " + ex.Message);
            }


        }
    }
}