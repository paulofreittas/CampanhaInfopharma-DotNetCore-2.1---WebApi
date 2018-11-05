using System.ComponentModel.DataAnnotations;

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
    }
}