using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Regrausuario
    {
        public Regrausuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeRegra { get; set; }
        public string DescricaoRegra { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
