using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Formulariopbm
    {
        public Formulariopbm()
        {
            Cliente = new HashSet<Cliente>();
            Codigodistribuidora = new HashSet<Codigodistribuidora>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? NumeroFuncionarios { get; set; }
        public bool? PossuiCartaoFidelidade { get; set; }
        public int? QuantidadeCartoesFidelidade { get; set; }
        public bool? PossuiConvenioComEmpresas { get; set; }
        public int? FormaReposicaoProdutos { get; set; }
        public DateTime? HorarioDiasSemanaInicial { get; set; }
        public DateTime? HorarioDiasSemanaFinal { get; set; }
        public DateTime? HorarioFinalSemanaInicial { get; set; }
        public DateTime? HorarioFinalSemanaFinal { get; set; }
        public DateTime? HorarioFeriadoInicial { get; set; }
        public DateTime? HorarioFeriadoFinal { get; set; }
        public bool? EntregaPeloConvenio { get; set; }
        public bool? CobraTaxaEntrega { get; set; }
        public decimal? ValorMinimoParaEntrega { get; set; }
        public int? AbrangenciaEntrega { get; set; }
        public int? SistemaOperacional { get; set; }
        public int? NumeroComputadores { get; set; }
        public int? TipoConexaoInternet { get; set; }
        public string CnpjSoftwareHouse { get; set; }
        public string TelefoneSoftwareHouse { get; set; }
        public string EmailSoftwareHouse { get; set; }
        public string NomeContidoNaConta { get; set; }
        public string NomeBanco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string NomeDaRede { get; set; }
        public int? QuantidadeConvenios { get; set; }
        public int? NumeroCaixas { get; set; }
        public string ContatoSoftwareHouse { get; set; }
        public int? TipoEmpresa { get; set; }
        public string NomeSoftwareHouse { get; set; }
        public string Software { get; set; }
        public int? RedeIdFk { get; set; }
        public int? ClienteIdFk { get; set; }
        public int? EmpresaSoftwareGestaoIdFk { get; set; }
        public int? Uf { get; set; }
        public string NumeroCrf { get; set; }
        public string NomeResponsavelTecnico { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Empresasoftwaregestao EmpresaSoftwareGestaoIdFkNavigation { get; set; }
        public Cliente RedeIdFkNavigation { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Codigodistribuidora> Codigodistribuidora { get; set; }
    }
}
