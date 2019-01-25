using System.Collections.Generic;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.Models
{
    public class DrogariaDTO
    {
        public int NumeroResultados { get; set; }
        public int Pagina { get; set; } 
        public IEnumerable<Cliente> Resultado { get; set; }
    }
}