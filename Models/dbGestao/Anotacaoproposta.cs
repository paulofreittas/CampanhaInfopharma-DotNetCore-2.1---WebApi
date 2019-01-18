using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Anotacaoproposta
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Anotacao { get; set; }
        public int? PropostaIdFk { get; set; }

        public Proposta PropostaIdFkNavigation { get; set; }
    }
}
