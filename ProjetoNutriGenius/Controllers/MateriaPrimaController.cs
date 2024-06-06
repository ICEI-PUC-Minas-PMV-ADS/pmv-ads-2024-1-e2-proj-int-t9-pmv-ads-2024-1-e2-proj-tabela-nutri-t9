using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/materia_prima")]
    [ApiController]
    public class MateriaPrimaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MateriaPrimaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost] // Criar um novo registro na tabela materia_prima do banco de dados
        public IActionResult CreateMateriaPrima(MateriaPrimaModel materiaPrimaModel)
        {
            try
            {
                var materiaPrima = new MateriaPrimaModel
                {
                    NomeMateriaPrima = materiaPrimaModel.NomeMateriaPrima
                };

                _context.materiaPrimaModel.Add(materiaPrimaModel);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao inserir registro: " + ex.Message);
            }
        }

        [HttpGet("{nome}")] // Retorna o registo filtrando-o pelo nome
        public IActionResult GetMateriaPrimaByNome(string nome)
        {
            var materiaPrima = _context.materiaPrimaModel.FirstOrDefault(p => p.NomeMateriaPrima == nome);
            if (materiaPrima == null)
            {
                return NotFound();
            }

            return Ok(materiaPrima);
        }

        [HttpGet("filtro/{nome}")] // Retorna o registo filtrando-o pelo nome
        public IActionResult GetMateriaPrimaFiltrado(string nome)
        {
            var materiaPrima = _context.materiaPrimaModel.Where(p => p.NomeMateriaPrima.Contains(nome));
            if (materiaPrima == null)
            {
                return NotFound();
            }

            return Ok(materiaPrima);
        }

        [HttpGet]
        public IActionResult GetAllMateriaPrima() // Retorna todo o registro
        {
            var materiaPrimaModel = _context.materiaPrimaModel;
            if (materiaPrimaModel == null)
            {
                return NotFound();
            }

            return Ok(materiaPrimaModel);
        }
    }
}