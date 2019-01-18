using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Coleta
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? Vezes { get; set; }
        public int? Periodo { get; set; }
        public bool? ResiduoA { get; set; }
        public bool? ResiduoB { get; set; }
        public bool? ResiduoD { get; set; }
        public bool? ResiduoE { get; set; }
        public int? IncineradoraIdFk { get; set; }
        public int? ClienteIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Incineradora IncineradoraIdFkNavigation { get; set; }
    }
}
