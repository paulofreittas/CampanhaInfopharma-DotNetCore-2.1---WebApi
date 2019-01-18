using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Abrangenciaservico
    {
        public Abrangenciaservico()
        {
            Cidadeabrangencia = new HashSet<Cidadeabrangencia>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public int? TipoAbrangencia { get; set; }
        public int? Uf { get; set; }
        public int? ServicoIdFk { get; set; }

        public Servico ServicoIdFkNavigation { get; set; }
        public ICollection<Cidadeabrangencia> Cidadeabrangencia { get; set; }
    }
}
