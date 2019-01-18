using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Dadoprocesso
    {
        public Dadoprocesso()
        {
            InverseDadoProcessoIdFkNavigation = new HashSet<Dadoprocesso>();
            Itemdado = new HashSet<Itemdado>();
            Regracontratoparcela = new HashSet<Regracontratoparcela>();
            Servico = new HashSet<Servico>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeDadoProcesso { get; set; }
        public string DescricaoDadoProcesso { get; set; }
        public int Tipo { get; set; }
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public int? ProcessoIdFk { get; set; }
        public string ValorCombo { get; set; }
        public string Acao { get; set; }
        public string NomeMetodo { get; set; }
        public int? TipoParametro { get; set; }
        public string ValorParametroString { get; set; }
        public bool? Desabilitavel { get; set; }
        public int? DadoProcessoIdFk { get; set; }

        public Dadoprocesso DadoProcessoIdFkNavigation { get; set; }
        public Processo ProcessoIdFkNavigation { get; set; }
        public ICollection<Dadoprocesso> InverseDadoProcessoIdFkNavigation { get; set; }
        public ICollection<Itemdado> Itemdado { get; set; }
        public ICollection<Regracontratoparcela> Regracontratoparcela { get; set; }
        public ICollection<Servico> Servico { get; set; }
    }
}
