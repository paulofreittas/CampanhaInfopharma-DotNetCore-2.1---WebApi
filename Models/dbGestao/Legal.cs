using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Legal
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? ResponsavelIdFk { get; set; }
        public int? ClienteIdFk { get; set; }
        public bool? ResponsavelContrato { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Responsavel ResponsavelIdFkNavigation { get; set; }
    }
}
