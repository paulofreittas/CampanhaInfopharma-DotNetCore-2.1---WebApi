using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Ligacao
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string Descricao { get; set; }
        public string NomeContato { get; set; }
        public int? ClienteIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
    }
}
