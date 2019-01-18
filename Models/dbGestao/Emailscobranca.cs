using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Emailscobranca
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataEnvio { get; set; }
        public string DescricaoEnvio { get; set; }
        public string Erro { get; set; }
        public int? LancamentoIdFk { get; set; }

        public Lancamento LancamentoIdFkNavigation { get; set; }
    }
}
