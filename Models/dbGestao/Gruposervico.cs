using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Gruposervico
    {
        public Gruposervico()
        {
            Agendamentoenviopropostas = new HashSet<Agendamentoenviopropostas>();
            Historicopropostas = new HashSet<Historicopropostas>();
            Servico = new HashSet<Servico>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? TipoOferta { get; set; }

        public ICollection<Agendamentoenviopropostas> Agendamentoenviopropostas { get; set; }
        public ICollection<Historicopropostas> Historicopropostas { get; set; }
        public ICollection<Servico> Servico { get; set; }
    }
}
