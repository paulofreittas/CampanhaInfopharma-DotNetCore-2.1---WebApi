using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historicosifap
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        public string Motivo { get; set; }
        public int? ContratoIdFk { get; set; }
        public int? ServicoIdFk { get; set; }
        public string Agencia { get; set; }
        public string CnpjCadastro { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
        public Servico ServicoIdFkNavigation { get; set; }
    }
}
