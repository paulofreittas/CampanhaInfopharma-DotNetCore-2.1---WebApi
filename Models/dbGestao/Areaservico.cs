using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Areaservico
    {
        public Areaservico()
        {
            Servico = new HashSet<Servico>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeArea { get; set; }
        public string DescricaoArea { get; set; }

        public ICollection<Servico> Servico { get; set; }
    }
}
