using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Cedente
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string CodigoCedenteNoBanco { get; set; }
        public int? TipoRemessa { get; set; }
        public int? IdentificacaoTitulo { get; set; }
        public bool? BancoEmiteBloqueto { get; set; }
        public int? EntregaDoBloqueto { get; set; }
        public int? EspecieDeTitulo { get; set; }
        public bool? Aceite { get; set; }
        public int? JuroDeMora { get; set; }
        public decimal? ValorJuroMora { get; set; }
        public decimal? PercentualJuroMora { get; set; }
        public int? TipoDesconto { get; set; }
        public decimal? PercentualDesconto { get; set; }
        public bool? ProtestarSePossivel { get; set; }
        public int? NumeroDeDiasParaProtesto { get; set; }
        public bool? BaixarDevolverTituloAoCendente { get; set; }
        public int? NumeroDeDiasBaixarDevolverAoCedente { get; set; }
        public string VersaoLayoutArquivo { get; set; }
        public string VersaoLayoutLote { get; set; }
        public int? Ambiente { get; set; }
        public bool? TitulosRegistrados { get; set; }
        public int? ClienteIdFk { get; set; }
        public string PathBoletos { get; set; }
        public int? PrazoSegundaVia { get; set; }
        public int? ContaIdFk { get; set; }
        public int? PlanoContasIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Conta ContaIdFkNavigation { get; set; }
        public Planocontas PlanoContasIdFkNavigation { get; set; }
    }
}
