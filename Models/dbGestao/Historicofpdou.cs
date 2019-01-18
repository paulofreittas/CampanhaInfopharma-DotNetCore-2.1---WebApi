using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historicofpdou
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? ContratoIdFk { get; set; }
        public int? OrdemServicoIdFk { get; set; }
        public bool Verificado { get; set; }
        public bool EnviadoCliente { get; set; }
        public int? PaginaDou { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public string DescricaoResultado { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
        public Ordemservico OrdemServicoIdFkNavigation { get; set; }
    }
}
