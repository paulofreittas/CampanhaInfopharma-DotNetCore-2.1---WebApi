using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Origemlancamento
    {
        public Origemlancamento()
        {
            Lancamento = new HashSet<Lancamento>();
            Lancamentoinativo = new HashSet<Lancamentoinativo>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Historico { get; set; }
        public int? Documento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime? DataEmissao { get; set; }
        public int? TipoOrigemLancamento { get; set; }
        public int? StatusOrigemLancamento { get; set; }
        public decimal? Multa { get; set; }
        public decimal? PercentualMulta { get; set; }
        public decimal? Juros { get; set; }
        public decimal? PercentualJuros { get; set; }
        public decimal? Valor { get; set; }
        public string Observacao { get; set; }
        public int? FornecedorIdFk { get; set; }
        public int? ContratoIdFk { get; set; }
        public bool? EntradaAvulsa { get; set; }
        public int? TipoBoleto { get; set; }
        public int? ClienteIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Contrato ContratoIdFkNavigation { get; set; }
        public Fornecedor FornecedorIdFkNavigation { get; set; }
        public ICollection<Lancamento> Lancamento { get; set; }
        public ICollection<Lancamentoinativo> Lancamentoinativo { get; set; }
    }
}
