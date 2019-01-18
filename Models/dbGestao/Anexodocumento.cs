using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Anexodocumento
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? TipoDocumentoServicoIdFk { get; set; }
        public int? DocumentoIdFk { get; set; }

        public Documento DocumentoIdFkNavigation { get; set; }
        public Tipodocumentoservico TipoDocumentoServicoIdFkNavigation { get; set; }
    }
}
