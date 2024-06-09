using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class MateriaPrimaService
{
    private readonly MyDbContext _context;

    public MateriaPrimaService(MyDbContext context)
    {
        _context = context;
    }

    // Create
    public void AdicionarMateriaPrima(MateriaPrimaModel materiaPrima)
    {
        _context.MateriasPrimaRepository.Add(materiaPrima);
        _context.SaveChanges();
    }

    // Read
    public MateriaPrimaModel ObterMateriaPrimaPorNome(string nome)
    {
        return _context.MateriasPrimaRepository.FirstOrDefault(mp => mp.nome_materia_prima == nome);
    }

    // Update
    public void AtualizarMateriaPrima(MateriaPrimaModel materiaPrima)
    {
        _context.Entry(materiaPrima).State = EntityState.Modified;
        _context.SaveChanges();
    }

    // Delete
    public void ExcluirMateriaPrima(string nome)
    {
        var materiaPrima = _context.MateriasPrimaRepository.FirstOrDefault(mp => mp.nome_materia_prima == nome);
        if (materiaPrima != null)
        {
            _context.MateriasPrimaRepository.Remove(materiaPrima);
            _context.SaveChanges();
        }
    }
}
