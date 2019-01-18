using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Servicowindows
    {
        public Servicowindows()
        {
            Logerrosservicoswindows = new HashSet<Logerrosservicoswindows>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeServico { get; set; }
        public string NomeDisplay { get; set; }
        public string DescricaoServico { get; set; }
        public int? Ordem { get; set; }
        public DateTime? UltimaExecucao { get; set; }

        public ICollection<Logerrosservicoswindows> Logerrosservicoswindows { get; set; }
    }
}
