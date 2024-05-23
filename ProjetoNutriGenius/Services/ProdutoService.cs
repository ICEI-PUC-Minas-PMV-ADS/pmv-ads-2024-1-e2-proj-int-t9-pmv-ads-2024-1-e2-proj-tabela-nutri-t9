using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class ProdutoService
{
    private readonly MyDbContext _context;

    public ProdutoService(MyDbContext context)
    {
        _context = context;
    }

    // Create
    public void AdicionarProduto(ProdutoModel produto)
    {
        _context.ProdutoRepository.Add(produto);
        _context.SaveChanges();
    }

    // Read
    public ProdutoModel ObterProduto(string nomeProduto)
    {
        return _context.ProdutoRepository.FirstOrDefault(mp => mp.nome_produto == nomeProduto);
    }

    // Update
    public void AtualizarProduto(ProdutoModel produto)
    {
        _context.Entry(produto).State = EntityState.Modified;
        _context.SaveChanges();
    }

    // Delete
    public void ExcluirProduto(string nomeProduto)
    {
        var produto = _context.ProdutoRepository.FirstOrDefault(mp => mp.nome_produto == nomeProduto);
        if (produto != null)
        {
            _context.ProdutoRepository.Remove(produto);
            _context.SaveChanges();
        }
    }
}