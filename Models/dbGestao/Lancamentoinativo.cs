using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Lancamentoinativo
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public decimal? Multa { get; set; }
        public decimal? Juros { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataLancamento { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? TaxaBoleto { get; set; }
        public decimal? Valor { get; set; }
        public decimal? ValorTotal { get; set; }
        public string IdentificacaoBoleto { get; set; }
        public int? StatusLancamento { get; set; }
        public int? OrigemLancamentoIdFk { get; set; }
        public int? LancamentoIdFk { get; set; }
        public string HistoricoLancamento { get; set; }
        public bool? Renegociado { get; set; }

        public Lancamento LancamentoIdFkNavigation { get; set; }
        public Origemlancamento OrigemLancamentoIdFkNavigation { get; set; }
    }
}
