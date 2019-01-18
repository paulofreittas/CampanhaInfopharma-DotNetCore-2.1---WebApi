using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Itemdado
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Valor { get; set; }
        public int? DadoProcessoIdFk { get; set; }
        public int? OrdemservicoIdFk { get; set; }

        public Dadoprocesso DadoProcessoIdFkNavigation { get; set; }
        public Ordemservico OrdemservicoIdFkNavigation { get; set; }
    }
}
