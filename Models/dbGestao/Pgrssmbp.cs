using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Pgrssmbp
    {
        public Pgrssmbp()
        {
            InversePgrssMbpIdFkNavigation = new HashSet<Pgrssmbp>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string TagTitulo { get; set; }
        public string Titulo { get; set; }
        public string TagTexto { get; set; }
        public string Texto { get; set; }
        public int? ServicoPopIdFk { get; set; }
        public int? PgrssMbpIdFk { get; set; }

        public Pgrssmbp PgrssMbpIdFkNavigation { get; set; }
        public Servicopop ServicoPopIdFkNavigation { get; set; }
        public ICollection<Pgrssmbp> InversePgrssMbpIdFkNavigation { get; set; }
    }
}
