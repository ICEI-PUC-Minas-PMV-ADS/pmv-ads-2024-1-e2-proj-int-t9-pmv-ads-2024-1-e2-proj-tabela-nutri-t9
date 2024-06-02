//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//[Table("produto")]
public class ProdutoModel
{
//    [Key]
    [Required]
    public string NomeProduto { get; set; }

    public Codigo_Produto ? CodigoProduto { get; set; }

//    [ForeignKey("usuario")]
//    public string Email { get; set; } =  string.Empty;

    [Required]
    public UsuarioModel ? Usuario { get; set; }

    [Required]
    public ProdutoMateriaPrimaModel ? ProdutoMateriaPrima;
}

public enum Codigo_Produto
{
    semiacabado,
    final
}
