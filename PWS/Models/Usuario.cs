using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PWS.Models
{

    public enum PerfilUsuario
    {
        Administrador,Padrao,Limitado
    }
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Login")]
        [Required]
        public string Login { get; set; }     
        
        [Column("Senha")]
        [Required]
        public string Senha { get; set; }

        [Column("ConfSenha")]
        [Required]
        public string ConfSenha { get; set; }

        [Column("EmailAddress")]
        [Required]
        public string Email { get; set; }

        [Column("PerfilUser")]
        [Required]
        public PerfilUsuario PerfilUser { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataMatricula { get; set; }


    }
}
