using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ProdutoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost] // Criar um novo registro na tabela materia_prima do banco de dados
        public IActionResult Create([FromBody] ProdutoModel produto)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var usuario = _context.UsuarioRepository.FirstOrDefault(p => p.Email == produto.Email);

                    if (usuario == null)
                    {
                        return NotFound("Usuário não encontrado.");
                    }

                    produto.Usuario = usuario;

                    _context.ProdutoRepository.Add(produto);
                    usuario.Produto.Add(produto);
                    _context.Entry(usuario).State = EntityState.Modified;
                    
                    _context.SaveChanges();
                    transaction.Commit();
            
                    return Ok();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return BadRequest("Erro ao inserir o produto: " + ex.Message);
                }
            }
        }

        [HttpGet("{nomeProduto}")]
        public IActionResult Read([FromQuery] string nomeProduto)
        {
            try 
            {
                var produto = _context.ProdutoRepository.FirstOrDefault(p => p.NomeProduto == nomeProduto);
                if (produto == null)
                {
                    return NotFound();
                }

                return Ok(produto);
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao buscar o produto: " + ex.Message);
            }
        }

        [HttpGet("filtro/{nomeProduto}")]
        public IActionResult GetMateriaPrimaFiltrado([FromQuery] string nomeProduto)
        {
            try 
            {
                var produto = _context.ProdutoRepository.Where(p => p.NomeProduto.Contains(nomeProduto));
                if (produto == null)
                {
                    return NotFound();
                }

                return Ok(produto);
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao buscar o(s) produto(s): " + ex.Message);
            }
        }

        [HttpGet()]
        public IActionResult GetAllProduto()
        {
            try
            {
                var produtos = _context.ProdutoRepository.ToList();
                
                if (produtos == null || !produtos.Any())
                {
                    return NotFound();
                }

                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao buscar os produtos: " + ex.Message);                
            }
        }

        [HttpPut()]
        public IActionResult UpdateProduto([FromBody] ProdutoModel produto) 
        {
            try 
            {
                _context.Entry(produto).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao atualizar o produto: " + ex.Message);
            }
        }

        [HttpDelete("nomeProduto")]
        public IActionResult DeleteProduto([FromQuery] string nomeProduto) {
            try
            {
                var produto = _context.ProdutoRepository.FirstOrDefault(e => e.NomeProduto == nomeProduto);

                if (produto != null)
                {
                    _context.ProdutoRepository.Remove(produto);
                    _context.SaveChanges();
                }

                return Ok();
            }
            catch (Exception ex) 
            {
                return BadRequest("Erro ao deletar o produto: " + ex.Message);
            }
        }
    }
}