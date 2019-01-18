using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Contratoparcelas
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public decimal ValorParcela { get; set; }
        public int? ContratoIdFk { get; set; }
        public int? Parcela { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
    }
}
