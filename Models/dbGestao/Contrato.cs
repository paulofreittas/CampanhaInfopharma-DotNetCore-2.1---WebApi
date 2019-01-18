using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Contrato
    {
        public Contrato()
        {
            Contratoparcelas = new HashSet<Contratoparcelas>();
            Historicoafe = new HashSet<Historicoafe>();
            Historicofp = new HashSet<Historicofp>();
            Historicofpdou = new HashSet<Historicofpdou>();
            Historicoliberacaopbm = new HashSet<Historicoliberacaopbm>();
            Historiconovosservicos = new HashSet<Historiconovosservicos>();
            Historicosifap = new HashSet<Historicosifap>();
            InverseContratoIdFkNavigation = new HashSet<Contrato>();
            Origemlancamento = new HashSet<Origemlancamento>();
            Peticionamentosafependentes = new HashSet<Peticionamentosafependentes>();
            PropostaCodcontratoNavigation = new HashSet<Proposta>();
            PropostaContratoIdFkNavigation = new HashSet<Proposta>();
            Servicocontrato = new HashSet<Servicocontrato>();
            Solicitacaocontrato = new HashSet<Solicitacaocontrato>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public int? DiaPagamento { get; set; }
        public bool? Vigente { get; set; }
        public string NumeroContrato { get; set; }
        public int? QtdParcelas { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorContrato { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorParcela { get; set; }
        public int? PlanoIdFk { get; set; }
        public int? ClienteIdFk { get; set; }
        public bool? GerarDocs { get; set; }
        public bool? EnviarDocs { get; set; }
        public bool? DocsEnviados { get; set; }
        public bool? ParcelasIguais { get; set; }
        public bool? PagamentoPosExecucao { get; set; }
        public DateTime? DataPrevisaoTermino { get; set; }
        public bool? BoletosGerados { get; set; }
        public int? RegraContratoIdFk { get; set; }
        public int? PropostaIdFk { get; set; }
        public bool? Inativo { get; set; }
        public bool? Assinado { get; set; }
        public int? TipoFechamentoContrato { get; set; }
        public int? ContratoIdFk { get; set; }
        public bool? ContratoFilial { get; set; }
        public bool? ContratoDigitalizado { get; set; }
        public int? FornecedorIdFk { get; set; }
        public DateTime? ValidadePacote { get; set; }
        public bool? PorRepresentante { get; set; }
        public bool? EntrouNaCampanha { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Contrato ContratoIdFkNavigation { get; set; }
        public Fornecedor FornecedorIdFkNavigation { get; set; }
        public Plano PlanoIdFkNavigation { get; set; }
        public Proposta PropostaIdFkNavigation { get; set; }
        public Regracontrato RegraContratoIdFkNavigation { get; set; }
        public ICollection<Contratoparcelas> Contratoparcelas { get; set; }
        public ICollection<Historicoafe> Historicoafe { get; set; }
        public ICollection<Historicofp> Historicofp { get; set; }
        public ICollection<Historicofpdou> Historicofpdou { get; set; }
        public ICollection<Historicoliberacaopbm> Historicoliberacaopbm { get; set; }
        public ICollection<Historiconovosservicos> Historiconovosservicos { get; set; }
        public ICollection<Historicosifap> Historicosifap { get; set; }
        public ICollection<Contrato> InverseContratoIdFkNavigation { get; set; }
        public ICollection<Origemlancamento> Origemlancamento { get; set; }
        public ICollection<Peticionamentosafependentes> Peticionamentosafependentes { get; set; }
        public ICollection<Proposta> PropostaCodcontratoNavigation { get; set; }
        public ICollection<Proposta> PropostaContratoIdFkNavigation { get; set; }
        public ICollection<Servicocontrato> Servicocontrato { get; set; }
        public ICollection<Solicitacaocontrato> Solicitacaocontrato { get; set; }
    }
}
