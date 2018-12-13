using System.Collections.Generic;

namespace CampanhaInfopharma.Models
{
    public class ContatoDrogariaDTO
    {
        public int NumeroResultados { get; set; }
        public int Pagina { get; set; }
        public IEnumerable<ContatoDrogaria> Resultado { get; set; }
    }
}