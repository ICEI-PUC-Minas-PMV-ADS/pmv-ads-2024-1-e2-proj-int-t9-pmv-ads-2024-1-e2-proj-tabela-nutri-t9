using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("materia_prima")]
public class MateriaPrimaModel
{
    [Key]
    public string nome_materia_prima { get; set; }
    public int valor_energetico { get; set; }
    public float carboidratos { get; set; }
    public float acucares_totais { get; set; }
    public float acucares_adicionados { get; set; }
    public float proteinas { get; set; }
    public float gorduras_totais { get; set; }
    public float gorduras_saturadas { get; set; }
    public float gorduras_trans { get; set; }
    public string fibra_alimentar { get; set; }
    public int sodio { get; set; }
}
