<<<<<<< HEAD
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//[Table("usuario")]
public class UsuarioModel
   {
        public UsuarioModel(string email)
        {
            Email = email;
            Produto = new List<ProdutoModel>();
            NomeUsuario = string.Empty;
            Senha = string.Empty;
            ConfirmeSenha = string.Empty;
            CNPJ = string.Empty;
            RazaoSocial = string.Empty;
            NomeCompleto = string.Empty;
            Celular = string.Empty;
            CEP = string.Empty;
            Numero = string.Empty; 
            Estado = string.Empty;
            Cidade = string.Empty;
            Bairro = string.Empty;
            Rua = string.Empty;
        }
        public string ? CNPJ { get; set; }

        [Display(Name = "Razão Social")]
        public string ? RazaoSocial { get; set; }

        public string ? NomeUsuario { get; set; }

        [Display(Name = "Nome completo")]
        public string ? NomeCompleto { get; set; }

        [Key]
        [EmailAddress]
        public required string Email { get; set; }

        [Phone]
        public string ? Celular { get; set; }

        [DataType(DataType.Password)]
        public string ? Senha { get; set; }

        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação de senha não correspondem.")]
        [Display(Name = "Confirme a senha")]
        public string ? ConfirmeSenha { get; set; }

        public string ? CEP { get; set; }

        public string ? Numero { get; set; }

        public string ? Estado { get; set; }

        public string ? Cidade { get; set; }

        public string ? Bairro { get; set; }

        public string ? Rua { get; set; }

        public ICollection<ProdutoModel> ? Produto {get; set;} = new List<ProdutoModel>();
    }
=======
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
>>>>>>> 41b1dab8af167fed35ea28bbe869a3cdb8dc717b
