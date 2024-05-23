using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext {
    public DbSet<MateriaPrimaModel> MateriasPrimaRepository { get; set; }
    public DbSet<ProdutoMateriaPrimaModel> ProdutoMateriaPrimaRepository { get; set; }
    public DbSet<ProdutoModel> ProdutoRepository { get; set; }
    public DbSet<UsuarioModel> UsuarioRepository { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        // Configurar a conexão com o banco de dados MySQL
        optionsBuilder.UseMySQL("server=localhost;database=nutrigenius_db;user=root;");
    }
}

