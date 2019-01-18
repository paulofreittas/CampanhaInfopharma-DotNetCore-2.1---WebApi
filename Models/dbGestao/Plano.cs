using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Plano
    {
        public Plano()
        {
            Contrato = new HashSet<Contrato>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomePlano { get; set; }
        public string DescricaoPlano { get; set; }
        public bool? Flexivel { get; set; }

        public ICollection<Contrato> Contrato { get; set; }
    }
}
