using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampanhaInfopharma.Enum;

namespace CampanhaInfopharma.Models
{
    public class ContatoDrogaria
    {
        public DateTime DataUltimaAlteracao { get; set; }
        [Required]
        [ForeignKey("Funcionario")]
        public int FuncionarioIdFk { get; set; }
        [Key, ForeignKey("Drogaria")]
        public int DrogariaIdFk { get; set; }
        public string Observacao { get; set; }
        public Status Status { get; set; }

        public virtual Drogaria Drogaria { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}