using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Processo
    {
        public Processo()
        {
            Dadoprocesso = new HashSet<Dadoprocesso>();
            Regracontratoparcela = new HashSet<Regracontratoparcela>();
            Servico = new HashSet<Servico>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeProcesso { get; set; }
        public string DescricaoProcesso { get; set; }
        public int Ordem { get; set; }
        public int NumeroLinhas { get; set; }
        public int NumeroColunas { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? NumeroProcesso { get; set; }
        public string IdentificacaoProcesso { get; set; }
        public int? TempoEstimado { get; set; }

        public Servico ServicoIdFkNavigation { get; set; }
        public ICollection<Dadoprocesso> Dadoprocesso { get; set; }
        public ICollection<Regracontratoparcela> Regracontratoparcela { get; set; }
        public ICollection<Servico> Servico { get; set; }
    }
}
