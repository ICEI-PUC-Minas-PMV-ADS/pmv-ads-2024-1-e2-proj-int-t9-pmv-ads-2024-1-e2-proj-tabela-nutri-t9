//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


//[Table("produto_materia_prima")]
public class ProdutoMateriaPrimaModel
{
//    [Key]
//    [ForeignKey("produto")]
//    public string NomeProduto { get; set; } = string.Empty;
//    [Key]
//    [ForeignKey("materia_prima")]
//    public string NomeMateriaPrima { get; set; } = string.Empty;
    public double ? Quantidade { get; set; }
    
    [Required]
    public string ? NomeMateriaPrima { get; set; }

    [Required]
    public string ? NomeProduto { get; set; }
}
