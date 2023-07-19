using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PWS.Models
{
    [Table("Docentes")]
    public class Docentes
    {
            [Key]
            [Column("Id")]
            [Required]
            public int ID { get; set; }

            [Required]
            [Column("Nome")]
            public string? Nome { get; set; }
           
            [Column("Idade")]
            public int Idade { get; set; }

            [Column("Email")]
            public string? Email { get; set; }

            [Column("cpf")]
            public string? CPF { get; set; }

            [Column("cnpj")]
            public string? CNPJ { get; set; }

            [Column("cep")]
            public string? CEP { get; set; }

            [Column("endereco")]
            public string? Endereco { get; set; }

            [Column("cidade")]
            public string? Cidade { get; set; }

            [Column("bairro")]
            public string? Bairro { get; set; }

            [Column("complemento")]
            public string? Complemento { get; set; }

            [Column("telefone")]
            public string? Telefone { get; set; }

            [Column("celular")]
            public string? Celular { get; set; }

            [Column("ativo")]
            public bool Ativo { get; set; }

            [Column("data_do_cadastro")]
            public DateTime Data_do_Cadastro { get; set; }

            [Column("observacao")]
            public string? Observacao { get; set; }
          
           [Column("Salario")]
           public double Salario { get; set; }

    }
}
