//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//[Table("usuario")]
public class UsuarioModel
   {
        public UsuarioModel()
        {
            NomeCompleto = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
            ConfirmeSenha = string.Empty;
        }

        public string ? CNPJ { get; set; }

        public string ? RazaoSocial { get; set; }

        [Required]
        public string NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string ? Email { get; set; }

        [Phone]
        public string ? Celular { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação de senha não correspondem.")]
        public string ? ConfirmeSenha { get; set; }

        public string ? CEP { get; set; }

        public string ? Numero { get; set; }

        public string ? Estado { get; set; }

        public string ? Cidade { get; set; }

        public string ? Bairro { get; set; }

        public string ? Rua { get; set; }
    }