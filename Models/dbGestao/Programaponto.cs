using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Programaponto
    {
        public Programaponto()
        {
            Pontocliente = new HashSet<Pontocliente>();
            Programapontotipoponto = new HashSet<Programapontotipoponto>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataValidade { get; set; }

        public ICollection<Pontocliente> Pontocliente { get; set; }
        public ICollection<Programapontotipoponto> Programapontotipoponto { get; set; }
    }
}
