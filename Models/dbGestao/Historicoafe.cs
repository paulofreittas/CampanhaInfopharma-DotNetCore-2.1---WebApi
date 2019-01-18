using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historicoafe
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int Status { get; set; }
        public int? OrdemServicoIdFk { get; set; }
        public int? ContratoIdFk { get; set; }
        public bool Verificado { get; set; }
        public int? ClienteIdFk { get; set; }
        public string DescricaoResultado { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Contrato ContratoIdFkNavigation { get; set; }
        public Ordemservico OrdemServicoIdFkNavigation { get; set; }
    }
}
