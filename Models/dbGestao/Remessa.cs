using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Remessa
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? NumeroRemessa { get; set; }
        public int? LancamentoId { get; set; }
        public string ConteudoArquivoRemessa { get; set; }
    }
}
