using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historicopropostas
    {
        public Historicopropostas()
        {
            Emailmarketing = new HashSet<Emailmarketing>();
            Proposta = new HashSet<Proposta>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataVerificacao { get; set; }
        public int? GrupoServicoIdFk { get; set; }
        public bool? Utilizado { get; set; }
        public int? SolicitacaoPropostasIdFk { get; set; }

        public Gruposervico GrupoServicoIdFkNavigation { get; set; }
        public Solicitacaopropostas SolicitacaoPropostasIdFkNavigation { get; set; }
        public ICollection<Emailmarketing> Emailmarketing { get; set; }
        public ICollection<Proposta> Proposta { get; set; }
    }
}
