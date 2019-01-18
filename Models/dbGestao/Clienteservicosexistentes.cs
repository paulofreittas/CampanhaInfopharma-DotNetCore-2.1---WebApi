using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Clienteservicosexistentes
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? ClienteIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Servico ServicoIdFkNavigation { get; set; }
    }
}
