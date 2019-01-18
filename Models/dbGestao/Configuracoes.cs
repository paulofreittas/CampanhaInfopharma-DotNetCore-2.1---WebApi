using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Configuracoes
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string PathDocs { get; set; }
        public string PathPops { get; set; }
        public string PathDestinoDocs { get; set; }
        public string PathDestinoPops { get; set; }
        public bool GerarSempre { get; set; }
        public int? ContaIdFk { get; set; }
        public int? PlanoContasIdFk { get; set; }
        public decimal MultaContrato { get; set; }
        public decimal JurosContrato { get; set; }
        public string PathDocsClientes { get; set; }
        public string Emails { get; set; }
        public int? TipoJurosContrato { get; set; }
        public int? TipoJurosPagar { get; set; }
        public string FromEmail { get; set; }
        public string FromNome { get; set; }
        public string BccEmails { get; set; }
        public string MensagemAtrasoPagamento { get; set; }
        public int? CarenciaAtrasoPagamento { get; set; }
        public int? DiaPgtoDadoprocesso { get; set; }
        public string PathArquivoConfigServicosWindows { get; set; }
        public string PathPbms { get; set; }
        public int? TipoCarenciaPrimeiraParcela { get; set; }
        public int? DiasCarenciaPrimeiraParcela { get; set; }
        public string FromFinanceiroEmail { get; set; }
        public string FromFinanceiroSenha { get; set; }
        public string FromFinanceiroNome { get; set; }
        public string BccFinanceiroEmails { get; set; }
        public int? DiasCarenciaContratoAVista { get; set; }
        public int? DiasProximaProposta { get; set; }
        public int? DiasValidadeProposta { get; set; }
        public string FromSmtp { get; set; }
        public int? FromPort { get; set; }
        public string FromFinanceiroSmtp { get; set; }
        public int? FromFinanceiroPort { get; set; }
        public string FromSenha { get; set; }
        public string PathPublic { get; set; }
        public string PathPropostas { get; set; }

        public Conta ContaIdFkNavigation { get; set; }
        public Planocontas PlanoContasIdFkNavigation { get; set; }
    }
}
