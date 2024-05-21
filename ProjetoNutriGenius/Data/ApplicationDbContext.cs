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
            entity.HasNoKey();
            entity.ToTable("materia_prima");
            entity.Property(e => e.NomeMateriaPrima).HasColumnName("nome_materia_prima"); // O nome da esquerda é o nome da propriedade dentro Classe e o da direita é o nome da coluna do banco de dados
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

    }
}