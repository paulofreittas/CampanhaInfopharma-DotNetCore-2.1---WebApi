using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Permissaousuario
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool? CanCreate { get; set; }
        public bool? CanRead { get; set; }
        public bool? CanUpdate { get; set; }
        public bool? CanDelete { get; set; }
        public int? TelaSistemaIdFk { get; set; }
        public int? UsuarioIdFk { get; set; }

        public Telasistema TelaSistemaIdFkNavigation { get; set; }
        public Usuario UsuarioIdFkNavigation { get; set; }
    }
}
