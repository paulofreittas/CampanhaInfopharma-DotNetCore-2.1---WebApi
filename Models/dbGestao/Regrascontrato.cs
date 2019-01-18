using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Regrascontrato
    {
        public int Codigo { get; set; }
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Quantidadeparcela { get; set; }
        public bool? Diapagamentocontrato { get; set; }
    }
}
