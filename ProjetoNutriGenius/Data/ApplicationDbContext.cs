using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
        : base(options)
    {
    }
    public DbSet<MateriaPrimaModel> materiaPrimaModel { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MateriaPrimaModel>(entity =>
        {
            entity.HasKey(e => new {e.NomeMateriaPrima});
            entity.ToTable("materia_prima");
            entity.Property(e => e.NomeMateriaPrima).HasColumnName("nome_materia_prima");
            entity.Property(e => e.ValorEnergetico).HasColumnName("valor_energetico");
            entity.Property(e => e.Carboidratos).HasColumnName("carboidratos");
            entity.Property(e => e.AcucaresTotais).HasColumnName("acucares_totais");
            entity.Property(e => e.AcucaresAdicionados).HasColumnName("acucares_adicionados");
            entity.Property(e => e.Proteinas).HasColumnName("proteinas");
            entity.Property(e => e.GordurasTotais).HasColumnName("gorduras_totais");
            entity.Property(e => e.GordurasSaturadas).HasColumnName("gorduras_saturadas");
            entity.Property(e => e.GordurasTrans).HasColumnName("gorduras_trans");
            entity.Property(e => e.FibraAlimentar).HasColumnName("fibra_alimentar");
            entity.Property(e => e.Sodio).HasColumnName("sodio");
        });

        modelBuilder.Entity<ProdutoMateriaPrimaModel>(entity =>
        {
            entity.HasKey(e => new {e.Produto.NomeProduto, e.MateriaPrima.NomeMateriaPrima});
            entity.ToTable("produto_materia_prima");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.HasOne(e => e.Produto)
                  .WithOne(e => e.ProdutoMateriaPrima)
                  .HasForeignKey<ProdutoModel>(e => e.NomeProduto)
                  .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(e => e.MateriaPrima)
                  .WithMany(e => e.ProdutoMateriaPrima)
                  .HasForeignKey(e => e.MateriaPrima.NomeMateriaPrima)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ProdutoModel>(entity =>
        {
            entity.HasKey(e => new {e.NomeProduto});
            entity.ToTable("produto");
            entity.Property(e => e.NomeProduto).HasColumnName("nome_produto");
            entity.Property(e => e.CodigoProduto).HasColumnName("codigo_produto");
            entity.HasOne(e => e.Usuario)
                .WithMany(e => e.Produto)
                .HasForeignKey(e => e.Usuario.Email)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<UsuarioModel>(entity =>
        {
            entity.HasKey(e => new {e.Email});
            entity.ToTable("usuario");
            entity.Property(e => e.NomeUsuario).HasColumnName("nome_usuario"); 
            entity.Property(e => e.Senha).HasColumnName("senha");
            entity.Property(e => e.Email).HasColumnName("email");
        });

    }
}