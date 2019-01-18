using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Regracontrato
    {
        public Regracontrato()
        {
            Contrato = new HashSet<Contrato>();
            Proposta = new HashSet<Proposta>();
            Regracontratoparcela = new HashSet<Regracontratoparcela>();
        }

        public int Codigo { get; set; }
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? Quantidadeparcela { get; set; }
        public bool? Diapagamentoespecifico { get; set; }
        public bool? Diapagamentocontrato { get; set; }

        public ICollection<Contrato> Contrato { get; set; }
        public ICollection<Proposta> Proposta { get; set; }
        public ICollection<Regracontratoparcela> Regracontratoparcela { get; set; }
    }
}
