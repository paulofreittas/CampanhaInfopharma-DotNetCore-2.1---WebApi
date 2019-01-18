using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Documentoservico
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? Quantidade { get; set; }
        public int? TipoDocumentoServicoIdFk { get; set; }
        public int? ServicoIdFk { get; set; }

        public Servico ServicoIdFkNavigation { get; set; }
        public Tipodocumentoservico TipoDocumentoServicoIdFkNavigation { get; set; }
    }
}
