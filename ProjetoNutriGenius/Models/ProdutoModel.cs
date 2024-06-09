<<<<<<< HEAD
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
=======
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
>>>>>>> 41b1dab8af167fed35ea28bbe869a3cdb8dc717b
}

public enum Codigo_Produto
{
    semiacabado,
    final
}
