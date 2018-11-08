using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampanhaInfopharma.Models
{
    public class Drogaria
    {
        public int Id { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        [MaxLength(18)]
        public string CNPJ { get; set; }
        public string NomeContato { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [ForeignKey("Funcionario")]
        public Nullable<int> FuncionarioIdFk { get; set; }

        public virtual Funcionario Funcionario { get; set; }
    }
}