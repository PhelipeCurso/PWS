using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace PWS.Models
{
    public enum StatusAluno
    {
        Aprovado,Recuperação,Reprovado
    }

    [Table("Aluno")]
    public class Alunos
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Nome")]
        [Required]
        public string Nome { get; set; }

        [Column("Idade")]
        public int Idade { get; set; }


        [Column("Matricula")]
        [Required]
        public ulong Matricula { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataMatricula { get; set; }

        [Column("EmailAddress")]
        public string Email { get; set; }

        [Column("CPF")]
        public double CPF { get; set; }

        [Column("CNPJ")]
        public double CNPJ { get; set; }
        
        [Column("Responsavel")]
        public string Responsavel { get; set; }
        
        [Column("DocResponsavel")]
        public string DocResp { get; set; }

        [Column("cep")]
        public string CEP { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("complemento")]
        public string? Complemento { get; set; }

        [Column("telefone")]
        public double? Telefone { get; set; }

        [Column("celular")]
        public double? Celular { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }

        [Column("data_do_cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data_do_Cadastro { get; set; }

        [Column("observacao")]
        public string? Observacao { get; set; }

        [Column("StatusAluno")]
        public StatusAluno? StatusAluno { get; set; }

        [Column("Instituição")]
        [Display(Name = "Instituição")]
        public string NameInst { get; set; }
       
    }
}