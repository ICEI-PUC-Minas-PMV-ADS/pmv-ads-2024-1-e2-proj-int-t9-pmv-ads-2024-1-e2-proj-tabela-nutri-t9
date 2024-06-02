//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//[Table("usuario")]
public class UsuarioModel
{
//    [Key]
    [Required]
    public string Email { get; set; }

    public string NomeUsuario { get; set; } = string.Empty;
    
    public string Senha { get; set; } = string.Empty;

    [Required]
    public ICollection<ProdutoModel> ? Produto { get; set; }
}
