using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Contatousuariocampanha
    {
        public int IdPk { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int ClienteIdFk { get; set; }
        public int UsuarioIdFk { get; set; }
        public int CampanhaRenovacaoIdFk { get; set; }
        public string Observacao { get; set; }
        public int TipoProposta { get; set; }

        public Campanharenovacao CampanhaRenovacaoIdFkNavigation { get; set; }
        public Cliente ClienteIdFkNavigation { get; set; }
        public Usuario UsuarioIdFkNavigation { get; set; }
    }
}
