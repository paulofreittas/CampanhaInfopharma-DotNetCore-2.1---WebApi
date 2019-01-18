using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Codigodistribuidora
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string ValorCodigo { get; set; }
        public int? DistribuidoraIdFk { get; set; }
        public int? FormularioPbmIdFk { get; set; }

        public Distribuidora DistribuidoraIdFkNavigation { get; set; }
        public Formulariopbm FormularioPbmIdFkNavigation { get; set; }
    }
}
