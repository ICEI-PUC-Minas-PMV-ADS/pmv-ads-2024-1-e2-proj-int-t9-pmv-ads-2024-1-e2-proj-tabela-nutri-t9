using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("produto")]
public class ProdutoModel
{
    [Key]
    public string nome_produto { get; set; }

    public Codigo_Produto codigo_produto { get; set; }

    [ForeignKey("usuario")]
    public string email { get; set; }
}

public enum Codigo_Produto
{
    semiacabado,
    final
}
