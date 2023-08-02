using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWS.Models
{
    [Table("Instituicao")]
    public class Instituicao
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        
        [Required]
        [Column("Nome")]
        public string NomeInstituicao { get; set; }

        [Required]
        [Column("CNPJ")]
        public string CNPJ { get; set;}

        [Column("Responsavel")]
        public string Responsavel { get; set; }

        [Column("CEP")]
        public string CEP { get; set; }

        [Column("Endereco")]
        public string Endereco { get; set; }

        [Column("Cidade")]
        public string Cidade { get; set; }

        [Column("Bairro")]
        public string Bairro { get; set; }

        [Column("Complemento")]
        public string? Complemento { get; set; }

        [Column("Telefone")]
        public double? Telefone { get; set; }

        [Column("ativo")]
        public bool? Ativo { get; set; }

        [Column("data_do_cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data_do_Cadastro { get; set; }
    }
}
