using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Proposta
    {
        public Proposta()
        {
            Anotacaoproposta = new HashSet<Anotacaoproposta>();
            Contrato = new HashSet<Contrato>();
            InversePropostaIdFkNavigation = new HashSet<Proposta>();
            Propostaservico = new HashSet<Propostaservico>();
            Propostausuario = new HashSet<Propostausuario>();
            Servicoproposta = new HashSet<Servicoproposta>();
        }

        public int IdPk { get; set; }
        public int ClienteIdFk { get; set; }
        public DateTime? Datainclusao { get; set; }
        public DateTime? Dataalteracao { get; set; }
        public int Formapgto { get; set; }
        public decimal Valortotal { get; set; }
        public int Qtdparcela { get; set; }
        public DateTime? Validadelicenca { get; set; }
        public int? Valortotalalterado { get; set; }
        public int Status { get; set; }
        public string Observacao { get; set; }
        public int? Id { get; set; }
        public int? Codcontrato { get; set; }
        public bool? Juros { get; set; }
        public decimal? Valortotalavista { get; set; }
        public int? Codregracontrato { get; set; }
        public bool? Contratoproposta { get; set; }
        public int? ContratoIdFk { get; set; }
        public string Telefones { get; set; }
        public DateTime? Primeiraparcela { get; set; }
        public int? UsuarioIdFk { get; set; }
        public int? Codigo { get; set; }
        public int? Codcliente { get; set; }
        public int? TipoFechamentoContrato { get; set; }
        public int? HistoricoPropostasIdFk { get; set; }
        public int? PropostaIdFk { get; set; }
        public bool? PropostaFilial { get; set; }
        public bool? PropostaMatriz { get; set; }
        public int? ClienteIndicadorIdFk { get; set; }
        public string Email { get; set; }
        public int? MotivoNaoFechamentoPropostaFk { get; set; }
        public decimal? Valorprimeiraparcela { get; set; }
        public DateTime? Validadepacote { get; set; }
        public bool? PorRepresentante { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Cliente ClienteIndicadorIdFkNavigation { get; set; }
        public Contrato CodcontratoNavigation { get; set; }
        public Regracontrato CodregracontratoNavigation { get; set; }
        public Contrato ContratoIdFkNavigation { get; set; }
        public Historicopropostas HistoricoPropostasIdFkNavigation { get; set; }
        public Motivonaofechamentoproposta MotivoNaoFechamentoPropostaFkNavigation { get; set; }
        public Proposta PropostaIdFkNavigation { get; set; }
        public Usuario UsuarioIdFkNavigation { get; set; }
        public ICollection<Anotacaoproposta> Anotacaoproposta { get; set; }
        public ICollection<Contrato> Contrato { get; set; }
        public ICollection<Proposta> InversePropostaIdFkNavigation { get; set; }
        public ICollection<Propostaservico> Propostaservico { get; set; }
        public ICollection<Propostausuario> Propostausuario { get; set; }
        public ICollection<Servicoproposta> Servicoproposta { get; set; }
    }
}
