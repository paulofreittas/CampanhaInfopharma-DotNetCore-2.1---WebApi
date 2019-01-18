using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Telasistema
    {
        public Telasistema()
        {
            Permissaousuario = new HashSet<Permissaousuario>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<Permissaousuario> Permissaousuario { get; set; }
    }
}
