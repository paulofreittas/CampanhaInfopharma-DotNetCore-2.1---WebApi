using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Pontocliente
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? UtilizadoDesconto { get; set; }
        public bool? UtilizadoPremio { get; set; }
        public bool? PrimeiroPonto { get; set; }
        public int? ProgramaPontoIdFk { get; set; }
        public int? ClienteIdFk { get; set; }
        public string DescricaoIndicado { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Programaponto ProgramaPontoIdFkNavigation { get; set; }
    }
}
