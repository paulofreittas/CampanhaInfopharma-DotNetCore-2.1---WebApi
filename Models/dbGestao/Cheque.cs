using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Cheque
    {
        public Cheque()
        {
            Lancamento = new HashSet<Lancamento>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCheque { get; set; }
        public decimal ValorCheque { get; set; }
        public bool Compensado { get; set; }
        public bool? Vinculado { get; set; }

        public ICollection<Lancamento> Lancamento { get; set; }
    }
}
