using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Tipodocumentoservico
    {
        public Tipodocumentoservico()
        {
            Anexodocumento = new HashSet<Anexodocumento>();
            Documentoservico = new HashSet<Documentoservico>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeTipoDocumentoServico { get; set; }
        public string DescricaoTipoDocumentoServico { get; set; }
        public bool? ContratoVigente { get; set; }
        public int? TipoContrato { get; set; }

        public ICollection<Anexodocumento> Anexodocumento { get; set; }
        public ICollection<Documentoservico> Documentoservico { get; set; }
    }
}
