using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Grupoordem
    {
        public Grupoordem()
        {
            Pesquisa = new HashSet<Pesquisa>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeArea { get; set; }

        public ICollection<Pesquisa> Pesquisa { get; set; }
    }
}
