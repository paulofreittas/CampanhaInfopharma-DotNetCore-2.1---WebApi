using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Peticionamentosafependentes
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? Pendente { get; set; }
        public int? ContratoIdFk { get; set; }
        public int? StatusPeticionamento { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
    }
}
