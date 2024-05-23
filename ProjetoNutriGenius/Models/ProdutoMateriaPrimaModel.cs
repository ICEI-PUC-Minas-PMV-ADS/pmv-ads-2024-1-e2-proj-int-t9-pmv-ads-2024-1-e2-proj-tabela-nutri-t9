using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("produto_materia_prima")]
public class ProdutoMateriaPrimaModel
{
    [Key]
    [ForeignKey("produto")]
    public string nome_produto { get; set; }
    [Key]
    [ForeignKey("materia_prima")]
    public string nome_materia_prima { get; set; }
    public double quantidade { get; set; }
}
