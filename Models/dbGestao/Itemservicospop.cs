using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Itemservicospop
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? PopIdFk { get; set; }
        public int? ServicoPopIdFk { get; set; }

        public Pops PopIdFkNavigation { get; set; }
        public Servicopop ServicoPopIdFkNavigation { get; set; }
    }
}
