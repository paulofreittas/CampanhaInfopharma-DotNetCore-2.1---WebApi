using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Planocontas
    {
        public Planocontas()
        {
            Cedente = new HashSet<Cedente>();
            Configuracoes = new HashSet<Configuracoes>();
            InversePlanoContasIdFkNavigation = new HashSet<Planocontas>();
            Lancamento = new HashSet<Lancamento>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomePlanoContas { get; set; }
        public string DescricaoPlanoContas { get; set; }
        public int? Nivel { get; set; }
        public int? TipoConta { get; set; }
        public int? PlanoContasIdFk { get; set; }
        public int Grupo { get; set; }
        public int? ContaIdFk { get; set; }
        public string TextoInclusaoAutomatica { get; set; }
        public bool? ReferenteAoMesAnterior { get; set; }

        public Conta ContaIdFkNavigation { get; set; }
        public Planocontas PlanoContasIdFkNavigation { get; set; }
        public ICollection<Cedente> Cedente { get; set; }
        public ICollection<Configuracoes> Configuracoes { get; set; }
        public ICollection<Planocontas> InversePlanoContasIdFkNavigation { get; set; }
        public ICollection<Lancamento> Lancamento { get; set; }
    }
}
