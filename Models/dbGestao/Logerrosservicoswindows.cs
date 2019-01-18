using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Logerrosservicoswindows
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string MensagemErro { get; set; }
        public DateTime? DataErro { get; set; }
        public bool? Visto { get; set; }
        public string MensagemExcecao { get; set; }
        public int? ServicoWindowsIdFk { get; set; }

        public Servicowindows ServicoWindowsIdFkNavigation { get; set; }
    }
}
