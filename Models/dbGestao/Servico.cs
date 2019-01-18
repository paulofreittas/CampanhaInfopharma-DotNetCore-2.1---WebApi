using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Servico
    {
        public Servico()
        {
            Abrangenciaservico = new HashSet<Abrangenciaservico>();
            Agendamentoemail = new HashSet<Agendamentoemail>();
            Clienteservicosexistentes = new HashSet<Clienteservicosexistentes>();
            Comissaousuario = new HashSet<Comissaousuario>();
            Documentoservico = new HashSet<Documentoservico>();
            Historicoliberacaopbm = new HashSet<Historicoliberacaopbm>();
            Historiconovosservicos = new HashSet<Historiconovosservicos>();
            Historicosifap = new HashSet<Historicosifap>();
            Ordemservico = new HashSet<Ordemservico>();
            Processo = new HashSet<Processo>();
            Propostaservico = new HashSet<Propostaservico>();
            Servicocontrato = new HashSet<Servicocontrato>();
            Servicodocumentos = new HashSet<Servicodocumentos>();
            Servicoproposta = new HashSet<Servicoproposta>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeServico { get; set; }
        public string DescricaoServico { get; set; }
        public decimal Valor { get; set; }
        public int? AreaServicoIdFk { get; set; }
        public bool? Avulso { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? VigenciaServico { get; set; }
        public int? TipoServicoIdFk { get; set; }
        public int? TipoOferta { get; set; }
        public int? GrupoServicoIdFk { get; set; }
        public bool? Inativo { get; set; }
        public decimal? ValorEntrada { get; set; }
        public string UrlImagem { get; set; }
        public string UrlSite { get; set; }
        public bool? GerarProcuracao { get; set; }
        public string HtmlResource { get; set; }
        public bool? SemProcesso { get; set; }
        public bool? Terceirizado { get; set; }
        public int? DiaPagamento { get; set; }
        public int? FornecedorIdFk { get; set; }
        public int? DadoProcessoIdFk { get; set; }
        public decimal? ValorDespesa { get; set; }
        public decimal? Valor2 { get; set; }
        public decimal? Valor3 { get; set; }

        public Areaservico AreaServicoIdFkNavigation { get; set; }
        public Dadoprocesso DadoProcessoIdFkNavigation { get; set; }
        public Fornecedor FornecedorIdFkNavigation { get; set; }
        public Gruposervico GrupoServicoIdFkNavigation { get; set; }
        public Processo ServicoIdFkNavigation { get; set; }
        public Tiposervico TipoServicoIdFkNavigation { get; set; }
        public ICollection<Abrangenciaservico> Abrangenciaservico { get; set; }
        public ICollection<Agendamentoemail> Agendamentoemail { get; set; }
        public ICollection<Clienteservicosexistentes> Clienteservicosexistentes { get; set; }
        public ICollection<Comissaousuario> Comissaousuario { get; set; }
        public ICollection<Documentoservico> Documentoservico { get; set; }
        public ICollection<Historicoliberacaopbm> Historicoliberacaopbm { get; set; }
        public ICollection<Historiconovosservicos> Historiconovosservicos { get; set; }
        public ICollection<Historicosifap> Historicosifap { get; set; }
        public ICollection<Ordemservico> Ordemservico { get; set; }
        public ICollection<Processo> Processo { get; set; }
        public ICollection<Propostaservico> Propostaservico { get; set; }
        public ICollection<Servicocontrato> Servicocontrato { get; set; }
        public ICollection<Servicodocumentos> Servicodocumentos { get; set; }
        public ICollection<Servicoproposta> Servicoproposta { get; set; }
    }
}
