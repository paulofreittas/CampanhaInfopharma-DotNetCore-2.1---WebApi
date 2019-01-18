using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Conta
    {
        public Conta()
        {
            Cedente = new HashSet<Cedente>();
            Configuracoes = new HashSet<Configuracoes>();
            Lancamento = new HashSet<Lancamento>();
            Planocontas = new HashSet<Planocontas>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeConta { get; set; }
        public string DescricaoConta { get; set; }
        public decimal? SaldoInicial { get; set; }
        public int? StatusConta { get; set; }

        public ICollection<Cedente> Cedente { get; set; }
        public ICollection<Configuracoes> Configuracoes { get; set; }
        public ICollection<Lancamento> Lancamento { get; set; }
        public ICollection<Planocontas> Planocontas { get; set; }
    }
}
