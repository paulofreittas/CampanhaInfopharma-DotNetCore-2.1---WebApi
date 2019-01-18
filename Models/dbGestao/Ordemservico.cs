using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Ordemservico
    {
        public Ordemservico()
        {
            Anotacaoos = new HashSet<Anotacaoos>();
            Historicoafe = new HashSet<Historicoafe>();
            Historicofp = new HashSet<Historicofp>();
            Historicofpdou = new HashSet<Historicofpdou>();
            Itemdado = new HashSet<Itemdado>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? ServicoIdFk { get; set; }
        public bool? Sucesso { get; set; }
        public int? Status { get; set; }
        public string NomeOrdem { get; set; }
        public int? NumeroOrdem { get; set; }
        public DateTime? DataOrdem { get; set; }
        public string Observacao { get; set; }

        public Servico ServicoIdFkNavigation { get; set; }
        public ICollection<Anotacaoos> Anotacaoos { get; set; }
        public ICollection<Historicoafe> Historicoafe { get; set; }
        public ICollection<Historicofp> Historicofp { get; set; }
        public ICollection<Historicofpdou> Historicofpdou { get; set; }
        public ICollection<Itemdado> Itemdado { get; set; }
    }
}
