<<<<<<< HEAD
//using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class MateriaPrimaModel
{
    [Key]
    public required string NomeMateriaPrima { get; set; }
    
    public int ? ValorEnergetico { get; set; }
    
    public float ? Carboidratos { get; set; }
    
    public float ? AcucaresTotais { get; set; }
    
    public float ? AcucaresAdicionados { get; set; }
    
    public float ? Proteinas { get; set; }
    
    public float ? GordurasTotais { get; set; }
    
    public float ? GordurasSaturadas { get; set; }
    
    public float ? GordurasTrans { get; set; }
    
    public float ? FibraAlimentar { get; set; }
    
    public int ? Sodio { get; set; }
    
    public ICollection<ProdutoMateriaPrimaModel> ? ProdutoMateriaPrima { get; set; } = new List<ProdutoMateriaPrimaModel>();
}


=======
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

>>>>>>> 41b1dab8af167fed35ea28bbe869a3cdb8dc717b
