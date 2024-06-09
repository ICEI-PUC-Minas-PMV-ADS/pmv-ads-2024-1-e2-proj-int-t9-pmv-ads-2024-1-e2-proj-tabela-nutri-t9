//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//[Table("produto")]
public class ProdutoModel
{
    [Key]
    public required string NomeProduto { get; set; }

    public Codigo_Produto ? CodigoProduto { get; set; }

    public required string Email { get; set; }

    [ForeignKey("Email")]
    public virtual UsuarioModel ? Usuario { get; set; }

    public ICollection<ProdutoMateriaPrimaModel> ? ProdutoMateriaPrima = new List<ProdutoMateriaPrimaModel>();
}

public enum Codigo_Produto
{
    semiacabado,
    final
}
