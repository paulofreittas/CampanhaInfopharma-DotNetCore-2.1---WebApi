using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Tipoponto
    {
        public Tipoponto()
        {
            Programapontotipoponto = new HashSet<Programapontotipoponto>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorDescontoPrimeiro { get; set; }
        public int? Tipo { get; set; }
        public int? PremioIdFk { get; set; }

        public Premio PremioIdFkNavigation { get; set; }
        public ICollection<Programapontotipoponto> Programapontotipoponto { get; set; }
    }
}
