using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CampanhaInfopharma.Enum;

namespace CampanhaInfopharma.Models
{
    public class ContatoDrogaria
    {
        public int Id { get; set; }
        public DateTime DataAlteracao { get; set; }
        [Required]
        [ForeignKey("Drogaria")]
        public int DrogariaIdFk { get; set; }
        public string Observacao { get; set; }
        public Status Status { get; set; }

        public virtual Drogaria Drogaria { get; set; }
    }
}