using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Agendamentoenviopropostas
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? DiaDaSemana { get; set; }
        public int? GrupoServicoIdFk { get; set; }

        public Gruposervico GrupoServicoIdFkNavigation { get; set; }
    }
}
