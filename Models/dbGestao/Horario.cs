using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Horario
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? Marcado { get; set; }
        public int? DiaSemana { get; set; }
        public DateTime? HorarioEntrada { get; set; }
        public DateTime? HorarioParada { get; set; }
        public DateTime? HorarioRetorno { get; set; }
        public DateTime? HorarioSaida { get; set; }
        public int? TecnicoIdFk { get; set; }

        public Tecnico TecnicoIdFkNavigation { get; set; }
    }
}
