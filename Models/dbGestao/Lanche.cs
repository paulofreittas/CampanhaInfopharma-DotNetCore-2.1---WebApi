using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Lanche
    {
        public Lanche()
        {
            Colaboradoreslanche = new HashSet<Colaboradoreslanche>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? TipoLanche { get; set; }
        public int? DiaSemana { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<Colaboradoreslanche> Colaboradoreslanche { get; set; }
    }
}
