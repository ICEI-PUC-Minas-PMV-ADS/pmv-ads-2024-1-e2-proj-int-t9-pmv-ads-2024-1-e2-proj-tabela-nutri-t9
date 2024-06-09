//using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class ProdutoMateriaPrimaModel
{
    public double ? Quantidade { get; set; }

    [Key]
    public required string NomeMateriaPrima { get; set; }

    [Key]
    public required string NomeProduto { get; set; }

    [ForeignKey("NomeProduto")]
    public virtual ProdutoModel ? Produto { get; set; }

    [ForeignKey("NomeMateriaPrima")]
    public virtual MateriaPrimaModel ? MateriaPrima { get; set; }
}
