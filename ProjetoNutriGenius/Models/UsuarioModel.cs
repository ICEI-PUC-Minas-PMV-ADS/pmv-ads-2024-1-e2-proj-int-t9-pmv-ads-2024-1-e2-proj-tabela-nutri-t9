using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("usuario")]
public class UsuarioModel
{
    [Key]
    public string email { get; set; }
    public string nome_usuario { get; set; }
    public string senha { get; set; }
}