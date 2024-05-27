
using Microsoft.EntityFrameworkCore;

public class ProdutoMateriaPrimaService
{
    private readonly MyDbContext _context;

    public ProdutoMateriaPrimaService(MyDbContext context)
    {
        _context = context;
    }

    // Create
    public void AdicionarProdutoMateriaPrima(ProdutoMateriaPrimaModel produtoMateriaPrima)
    {
        _context.ProdutoMateriaPrimaRepository.Add(produtoMateriaPrima);
        _context.SaveChanges();
    }

    // Read
    public ProdutoMateriaPrimaModel ObterProdutoMateriaPrimaPorNomes(string nomeProduto, string nomeMateriaPrima)
    {
        return _context.ProdutoMateriaPrimaRepository.FirstOrDefault(mp => mp.nome_produto == nomeProduto && mp.nome_materia_prima == nomeMateriaPrima);
    }

    // Update
    public void AtualizarProdutoMateriaPrima(ProdutoMateriaPrimaModel produtoMateriaPrima)
    {
        _context.Entry(produtoMateriaPrima).State = EntityState.Modified;
        _context.SaveChanges();
    }

    // Delete
    public void ExcluirProdutoMateriaPrima(string nomeProduto, string nomeMateriaPrima)
    {
        var produtoMateriaPrima = _context.ProdutoMateriaPrimaRepository.FirstOrDefault(mp => mp.nome_produto == nomeProduto && mp.nome_materia_prima == nomeMateriaPrima);
        if (produtoMateriaPrima != null)
        {
            _context.ProdutoMateriaPrimaRepository.Remove(produtoMateriaPrima);
            _context.SaveChanges();
        }
    }
}
