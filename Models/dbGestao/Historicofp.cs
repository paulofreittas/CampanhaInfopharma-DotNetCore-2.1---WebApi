using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historicofp
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string TituloEmail { get; set; }
        public string TextoEmail { get; set; }
        public DateTime? DataEmail { get; set; }
        public string EmailOrigem { get; set; }
        public int Status { get; set; }
        public int? OrdemServicoIdFk { get; set; }
        public bool Verificado { get; set; }
        public int? ContratoIdFk { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
        public Ordemservico OrdemServicoIdFkNavigation { get; set; }
    }
}
