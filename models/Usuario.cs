namespace CadastroTCC.models;
using CadastroTCC.models.Enuns;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Cadastro")]

public class Usuario
    {
        [Key]
        [Column("Cpf")]
         public int Cpf { get; set; }
         [Column("Nome")]
        public string Nome { get; set; }
        [Column("Apelido")]
        public string Apelido { get; set; }
        [Column("Dt_nasc")]
        public DateTime DataDeNascimento { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Senha")]
        public string Senha { get; set; }
        [Column("Nivel")]
        public NivelEnuns Nivel{ get; set;}

    }
      


