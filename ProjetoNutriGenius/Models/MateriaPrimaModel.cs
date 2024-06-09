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


