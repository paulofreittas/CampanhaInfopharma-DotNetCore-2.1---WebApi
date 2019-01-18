using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Cidadeabrangencia
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? CidadeIdFk { get; set; }
        public int? AbrangenciaServicoIdFk { get; set; }

        public Abrangenciaservico AbrangenciaServicoIdFkNavigation { get; set; }
        public Cidade CidadeIdFkNavigation { get; set; }
    }
}
