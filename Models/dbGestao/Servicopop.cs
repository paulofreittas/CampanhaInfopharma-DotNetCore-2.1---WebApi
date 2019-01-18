using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Servicopop
    {
        public Servicopop()
        {
            Itemservicospop = new HashSet<Itemservicospop>();
            Pgrssmbp = new HashSet<Pgrssmbp>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string DescricaoServico { get; set; }
        public string NomeServico { get; set; }
        public bool? Obrigatorio { get; set; }

        public ICollection<Itemservicospop> Itemservicospop { get; set; }
        public ICollection<Pgrssmbp> Pgrssmbp { get; set; }
    }
}
