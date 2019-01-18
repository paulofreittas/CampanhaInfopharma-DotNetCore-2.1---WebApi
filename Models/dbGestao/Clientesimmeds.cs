using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Clientesimmeds
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public int? ClienteIdFk { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Cnpj { get; set; }
        public bool? EmailNovoClienteEnviado { get; set; }
        public DateTime? DataInicialLicenca { get; set; }
        public DateTime? DataFinalLicenca { get; set; }
        public bool? Teste { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? DataUltimaUtilizacao { get; set; }
        public DateTime? DataEmailNaoAbriuSimMeds { get; set; }
        public DateTime? DataUltimoEnvio { get; set; }
        public DateTime? DataEmailEnvioAtrasado { get; set; }
        public bool? ErroValidacaoUltimoEnvio { get; set; }
        public string MensagemErroValidacao { get; set; }
        public DateTime? DataEmailErroValidacao { get; set; }
        public string EmailContato { get; set; }
        public string EmailSngpc { get; set; }
        public string SenhaSngpc { get; set; }
        public string CpfSngpc { get; set; }
        public string NomeContato { get; set; }
        public DateTime? DataEmailProximoDoVencimento { get; set; }
        public DateTime? DataEmailNaoSolicitouBoleto { get; set; }
        public DateTime? DataEmailSatisfacaoCliente { get; set; }
        public bool? BoletoAberto { get; set; }
        public string SerialHd { get; set; }
        public string SerialProcessador { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
    }
}
