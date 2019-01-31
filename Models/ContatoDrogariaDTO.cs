using System.Collections.Generic;
using CampanhaInfopharma.Models.dbGestao;

namespace CampanhaInfopharma.Models
{
    public class ContatoDrogariaDTO
    {
        public int NumeroResultados { get; set; }
        public int Pagina { get; set; }
        public IEnumerable<Contatousuariocampanha> Resultado { get; set; }
    }
}