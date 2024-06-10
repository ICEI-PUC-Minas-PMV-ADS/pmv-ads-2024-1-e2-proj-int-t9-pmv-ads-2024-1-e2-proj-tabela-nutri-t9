using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
        : base(options)
    {
    }
    public DbSet<MateriaPrimaModel> MateriaPrimaRepository { get; set; }
    public DbSet<UsuarioModel> UsuarioRepository { get; set; }
    public DbSet<ProdutoModel> ProdutoRepository { get; set; }
    public DbSet<ProdutoMateriaPrimaModel> ProdutoMateriaPrimaRepository { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MateriaPrimaModel>(entity =>
        {
            entity.ToTable("materia_prima").HasKey(e => e.NomeMateriaPrima);
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
            entity.HasKey(e => new {e.NomeProduto, e.NomeMateriaPrima});
            entity.ToTable("produto_materia_prima");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.HasOne(e => e.Produto)
                  .WithMany(e => e.ProdutoMateriaPrima)
                  .HasForeignKey(e => e.NomeProduto)
                  .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(e => e.MateriaPrima)
                  .WithMany(e => e.ProdutoMateriaPrima)
                  .HasForeignKey(e => e.NomeMateriaPrima)
                  .OnDelete(DeleteBehavior.Cascade);

        });

        modelBuilder.Entity<ProdutoModel>(entity =>
        {
            entity.HasKey(e => new {e.NomeProduto});
            entity.ToTable("produto");
            entity.Property(e => e.NomeProduto).HasColumnName("nome_produto");
            entity.Property(e => e.CodigoProduto).HasColumnName("codigo_produto").HasConversion(
              v => v.ToString(),      // Converts enum to string for database
              v => (Codigo_Produto)Enum.Parse(typeof(Codigo_Produto), v)  // Converts string back to enum
            ).IsRequired(false); // Update based on whether it's a required field;
            entity.Property(e => e.Email).HasColumnName("email");
            entity.HasOne(e => e.Usuario)
                  .WithMany(e => e.Produto)
                  .HasForeignKey(e => e.Email)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<UsuarioModel>(entity =>
        {
            entity.HasKey(e => new {e.Email});
            entity.ToTable("usuario"); 
            entity.Property(e => e.NomeUsuario).IsRequired().HasColumnName("nome_usuario");
            entity.Property(e => e.NomeCompleto).IsRequired().HasColumnName("nome_completo");
            entity.Property(e => e.Email).IsRequired().HasColumnName("email");
            entity.Property(e => e.Celular).HasColumnName("celular");
            entity.Property(e => e.CNPJ).HasColumnName("cadastro_nacional");
            entity.Property(e => e.RazaoSocial).HasColumnName("razao_social");
            entity.Property(e => e.Senha).IsRequired().HasColumnName("senha");
            entity.Property(e => e.ConfirmeSenha).IsRequired().HasColumnName("confirme_senha");
            entity.Property(e => e.CEP).HasColumnName("cep");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Cidade).HasColumnName("cidade");
            entity.Property(e => e.Bairro).HasColumnName("bairro");
            entity.Property(e => e.Rua).HasColumnName("rua");
        });        

    }
}