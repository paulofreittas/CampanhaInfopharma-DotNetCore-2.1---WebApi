using System.Collections.Generic;

namespace CampanhaInfopharma.Models
{
    public class DrogariaDTO
    {
        public int NumeroResultados { get; set; }
        public int Pagina { get; set; } 
        public IEnumerable<ClienteFuncionario> Resultado { get; set; }
    }
}