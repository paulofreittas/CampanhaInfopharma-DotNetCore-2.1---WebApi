using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Servicoproposta
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public decimal? Valor { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? PropostaIdFk { get; set; }

        public Proposta PropostaIdFkNavigation { get; set; }
        public Servico ServicoIdFkNavigation { get; set; }
    }
}
