using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Tiposenhacliente
    {
        public Tiposenhacliente()
        {
            Senhacliente = new HashSet<Senhacliente>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<Senhacliente> Senhacliente { get; set; }
    }
}
