using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historicoliberacaopbm
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? ContratoIdFk { get; set; }
        public bool? Visualizado { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
        public Servico ServicoIdFkNavigation { get; set; }
    }
}
