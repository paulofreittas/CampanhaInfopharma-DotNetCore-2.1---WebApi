using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Lancamento
    {
        public Lancamento()
        {
            Emailscobranca = new HashSet<Emailscobranca>();
            Lancamentoinativo = new HashSet<Lancamentoinativo>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? MeioPagamento { get; set; }
        public decimal? Multa { get; set; }
        public decimal? Juros { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataLancamento { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Valor { get; set; }
        public decimal? ValorTotal { get; set; }
        public int? Parcela { get; set; }
        public string CodigoBarras { get; set; }
        public int? Documento { get; set; }
        public string NumeroDocumento { get; set; }
        public int? StatusLancamento { get; set; }
        public int? OrigemLancamentoIdFk { get; set; }
        public int? ContaIdFk { get; set; }
        public int? PlanoContasIdFk { get; set; }
        public decimal? TaxaBoleto { get; set; }
        public int? ChequeIdFk { get; set; }
        public string HistoricoLancamento { get; set; }
        public string IdentificacaoBoleto { get; set; }
        public int? VezesCartao { get; set; }
        public int? TipoBaixa { get; set; }
        public bool? EmailPreVencimento { get; set; }
        public bool? EmailLogoAposVencimento { get; set; }
        public bool? EmailAposVencimento { get; set; }
        public string NomeBoletoParaUpload { get; set; }
        public string LinhaDigitavel { get; set; }
        public bool? ConfirmadoRecebimentoBoleto { get; set; }
        public bool? Registrado { get; set; }
        public bool? Rejeitado { get; set; }

        public Cheque ChequeIdFkNavigation { get; set; }
        public Conta ContaIdFkNavigation { get; set; }
        public Origemlancamento OrigemLancamentoIdFkNavigation { get; set; }
        public Planocontas PlanoContasIdFkNavigation { get; set; }
        public ICollection<Emailscobranca> Emailscobranca { get; set; }
        public ICollection<Lancamentoinativo> Lancamentoinativo { get; set; }
    }
}
