using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

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

        [HttpPost] // Criar um novo registro na tabela materia_prima do banco de dados
        public IActionResult Create([FromBody] UsuarioModel usuario)
        {
            try
            {
                _context.UsuarioRepository.Add(usuario);
                _context.SaveChanges();
           
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao inserir o usuário: " + ex.Message);
            }
        }

        [HttpGet("{email}")]
        public IActionResult Read([FromQuery] string email)
        {
            try 
            {
                var usuario = _context.UsuarioRepository.FirstOrDefault(p => p.Email == email);
                if (usuario == null)
                {
                    return NotFound();
                }

                return Ok(usuario);
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao buscar o usuário: " + ex.Message);
            }
        }

        [HttpGet()]
        public IActionResult GetAllProduto()
        {
            try
            {
                var usuarios = _context.UsuarioRepository.ToList();
                
                if (usuarios == null || !usuarios.Any())
                {
                    return NotFound();
                }

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao buscar os usuário: " + ex.Message);                
            }
        }

        [HttpPut()]
        public IActionResult UpdateProduto([FromBody] UsuarioModel usuario) 
        {
            try 
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao atualizar o usuário: " + ex.Message);
            }
        }

        [HttpDelete("email")]
        public IActionResult DeleteProduto([FromQuery] string email) {
            try
            {
                var usuario = _context.UsuarioRepository.FirstOrDefault(e => e.Email == email);

                if (usuario != null)
                {
                    _context.UsuarioRepository.Remove(usuario);
                    _context.SaveChanges();
                }

                return Ok();
            }
            catch (Exception ex) 
            {
                return BadRequest("Erro ao deletar o usuário: " + ex.Message);
            }
        }
    }
}