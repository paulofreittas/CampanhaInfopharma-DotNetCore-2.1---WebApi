using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Senhacliente
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int? TipoSenhaClienteIdFk { get; set; }
        public int? ClienteIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Tiposenhacliente TipoSenhaClienteIdFkNavigation { get; set; }
    }
}
