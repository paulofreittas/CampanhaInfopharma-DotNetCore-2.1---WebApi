using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Colaboradoreslanche
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int? Ordem { get; set; }
        public bool? Atual { get; set; }
        public DateTime? DataUltimoPagamento { get; set; }
        public int? Sabor { get; set; }
        public int? LancheIdFk { get; set; }

        public Lanche LancheIdFkNavigation { get; set; }
    }
}
