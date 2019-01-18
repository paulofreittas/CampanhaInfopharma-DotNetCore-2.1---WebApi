using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Programapontotipoponto
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? ProgramaPontoIdFk { get; set; }

        public Programaponto ProgramaPontoIdFkNavigation { get; set; }
        public Tipoponto ServicoIdFkNavigation { get; set; }
    }
}
