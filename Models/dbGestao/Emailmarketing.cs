using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Emailmarketing
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public int ClienteIdFk { get; set; }
        public int? UsuarioIdFk { get; set; }
        public string Email { get; set; }
        public int? HistoricoPropostasIdFk { get; set; }
        public bool? Enviado { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Historicopropostas HistoricoPropostasIdFkNavigation { get; set; }
        public Usuario UsuarioIdFkNavigation { get; set; }
    }
}
