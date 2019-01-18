using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Motivonaofechamentoproposta
    {
        public Motivonaofechamentoproposta()
        {
            Proposta = new HashSet<Proposta>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Descricao { get; set; }
        public bool? Status { get; set; }

        public ICollection<Proposta> Proposta { get; set; }
    }
}
