using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class UsuarioService
{
    private readonly MyDbContext _context;

    public UsuarioService(MyDbContext context)
    {
        _context = context;
    }

    // Create
    public void AdicionarUsuario(UsuarioModel usuario)
    {
        _context.UsuarioRepository.Add(usuario);
        _context.SaveChanges();
    }

    // Read
    public UsuarioModel ObterUsuarioPorEmail(string email)
    {
        return _context.UsuarioRepository.FirstOrDefault(mp => mp.email == email);
    }

    // Update
    public void AtualizarUsuario(UsuarioModel usuario)
    {
        _context.Entry(usuario).State = EntityState.Modified;
        _context.SaveChanges();
    }

    // Delete
    public void ExcluirUsuario(string email)
    {
        var usuario = _context.UsuarioRepository.FirstOrDefault(mp => mp.email == email);
        if (usuario != null)
        {
            _context.UsuarioRepository.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
