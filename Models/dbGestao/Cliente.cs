using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Cliente
    {
        public Cliente()
        {
            Agendamentoligacao = new HashSet<Agendamentoligacao>();
            Cedente = new HashSet<Cedente>();
            Clienteservicosexistentes = new HashSet<Clienteservicosexistentes>();
            Clientesimmeds = new HashSet<Clientesimmeds>();
            Coleta = new HashSet<Coleta>();
            Configuracaodescontocliente = new HashSet<Configuracaodescontocliente>();
            Contatousuariocampanha = new HashSet<Contatousuariocampanha>();
            Contrato = new HashSet<Contrato>();
            Emailmarketing = new HashSet<Emailmarketing>();
            FormulariopbmClienteIdFkNavigation = new HashSet<Formulariopbm>();
            FormulariopbmRedeIdFkNavigation = new HashSet<Formulariopbm>();
            Historicoafe = new HashSet<Historicoafe>();
            InverseClienteIdFkNavigation = new HashSet<Cliente>();
            Legal = new HashSet<Legal>();
            Ligacao = new HashSet<Ligacao>();
            Ordempesquisa = new HashSet<Ordempesquisa>();
            Origemlancamento = new HashSet<Origemlancamento>();
            Pontocliente = new HashSet<Pontocliente>();
            Pops = new HashSet<Pops>();
            PropostaClienteIdFkNavigation = new HashSet<Proposta>();
            PropostaClienteIndicadorIdFkNavigation = new HashSet<Proposta>();
            Senhacliente = new HashSet<Senhacliente>();
            Solicitacaodoc = new HashSet<Solicitacaodoc>();
            Tecnico = new HashSet<Tecnico>();
            Telefone = new HashSet<Telefone>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string NumeroAutorizacao { get; set; }
        public DateTime? DataAutorizacao { get; set; }
        public int? Situacao { get; set; }
        public int? Uf { get; set; }
        public int? SistemaGerencial { get; set; }
        public int? SistemaSngpc { get; set; }
        public int? ListaPrecos { get; set; }
        public string Observacao { get; set; }
        public bool? ContratoFechado { get; set; }
        public DateTime? DataInicioFuncionamento { get; set; }
        public DateTime? HorarioEntradaSemana { get; set; }
        public DateTime? HorarioSaidaSemana { get; set; }
        public DateTime? HorarioEntradaSabado { get; set; }
        public DateTime? HorarioSaidaSabado { get; set; }
        public DateTime? HorarioEntradaDomingo { get; set; }
        public DateTime? HorarioSaidaDomingo { get; set; }
        public decimal? AreaConstruida { get; set; }
        public decimal? AreaTerreno { get; set; }
        public byte[] Logo { get; set; }
        public int? CidadeIdFk { get; set; }
        public int? BairroIdFk { get; set; }
        public int? NomeIncineradora { get; set; }
        public string NomeSkype { get; set; }
        public string NomeMsn { get; set; }
        public string NomeContatoDrogaria { get; set; }
        public string EmailEmpresaAnvisa { get; set; }
        public string SenhaEmpresaAnvisa { get; set; }
        public int? PopsIdFk { get; set; }
        public int? Atividade { get; set; }
        public string NumeroAlvara { get; set; }
        public int? AnoExercicioAlvara { get; set; }
        public string NumeroRegularidade { get; set; }
        public DateTime? DataValidadeRegularidade { get; set; }
        public string EmailSngpc { get; set; }
        public string SenhaSngpc { get; set; }
        public string JuntaComercial { get; set; }
        public bool? CndPendente { get; set; }
        public string HorarioFuncionamentoSemana { get; set; }
        public string HorarioFuncionamentoSabado { get; set; }
        public string HorarioFuncionamentoDomingo { get; set; }
        public bool? Incompleto { get; set; }
        public bool DesabilitarAfe { get; set; }
        public bool? AlvaraPendente { get; set; }
        public DateTime? DataValidadeAlvara { get; set; }
        public DateTime? DataValidadeCnd { get; set; }
        public bool? RegularidadePendente { get; set; }
        public bool? Inativo { get; set; }
        public string Nis { get; set; }
        public string SenhaNis { get; set; }
        public string UsuarioPortalDrogaria { get; set; }
        public string SenhaPortalDrogaria { get; set; }
        public int? Distribuidora1 { get; set; }
        public int? Distribuidora2 { get; set; }
        public int? Distribuidora3 { get; set; }
        public int? Distribuidora4 { get; set; }
        public int? EmpresaSoftwareGestaoIdFk { get; set; }
        public bool? Matriz { get; set; }
        [NotMapped]
        public int? ClienteIdFk { get; set; }
        public string UsuarioFp { get; set; }
        public string SenhaFp { get; set; }
        public string EmailFp { get; set; }
        public string SenhaEmailFp { get; set; }
        public bool? NisValido { get; set; }
        public int? TipoLogradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string HorarioFuncionamentoFeriados { get; set; }
        public int? FormularioPbmIdFk { get; set; }
        public string Email { get; set; }
        public string CidadeNis { get; set; }
        public string AgenciaNis { get; set; }
        public bool? Spc { get; set; }
        public string ContatoFinanceiro { get; set; }
        public bool? BoletoConfirmado { get; set; }
        public bool? Renegociado { get; set; }
        public int? HospitalIdFk { get; set; }
        public bool? BoletosRegistrados { get; set; }

        public Bairro BairroIdFkNavigation { get; set; }
        public Cidade CidadeIdFkNavigation { get; set; }
        public Cliente ClienteIdFkNavigation { get; set; }
        public Empresasoftwaregestao EmpresaSoftwareGestaoIdFkNavigation { get; set; }
        public Formulariopbm FormularioPbmIdFkNavigation { get; set; }
        public Hospital HospitalIdFkNavigation { get; set; }
        public Pops PopsIdFkNavigation { get; set; }
        public ICollection<Agendamentoligacao> Agendamentoligacao { get; set; }
        public ICollection<Cedente> Cedente { get; set; }
        public ICollection<Clienteservicosexistentes> Clienteservicosexistentes { get; set; }
        public ICollection<Clientesimmeds> Clientesimmeds { get; set; }
        public ICollection<Coleta> Coleta { get; set; }
        public ICollection<Configuracaodescontocliente> Configuracaodescontocliente { get; set; }
        public ICollection<Contatousuariocampanha> Contatousuariocampanha { get; set; }
        public ICollection<Contrato> Contrato { get; set; }
        public ICollection<Emailmarketing> Emailmarketing { get; set; }
        public ICollection<Formulariopbm> FormulariopbmClienteIdFkNavigation { get; set; }
        public ICollection<Formulariopbm> FormulariopbmRedeIdFkNavigation { get; set; }
        public ICollection<Historicoafe> Historicoafe { get; set; }
        [NotMapped]
        public ICollection<Cliente> InverseClienteIdFkNavigation { get; set; }
        public ICollection<Legal> Legal { get; set; }
        public ICollection<Ligacao> Ligacao { get; set; }
        public ICollection<Ordempesquisa> Ordempesquisa { get; set; }
        public ICollection<Origemlancamento> Origemlancamento { get; set; }
        public ICollection<Pontocliente> Pontocliente { get; set; }
        public ICollection<Pops> Pops { get; set; }
        public ICollection<Proposta> PropostaClienteIdFkNavigation { get; set; }
        public ICollection<Proposta> PropostaClienteIndicadorIdFkNavigation { get; set; }
        public ICollection<Senhacliente> Senhacliente { get; set; }
        public ICollection<Solicitacaodoc> Solicitacaodoc { get; set; }
        public ICollection<Tecnico> Tecnico { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
    }
}
