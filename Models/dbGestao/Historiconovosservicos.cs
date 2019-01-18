using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Historiconovosservicos
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Visto { get; set; }
        public int? ContratoIdFk { get; set; }
        public int? ServicoIdFk { get; set; }
        public int? UsuarioIdFk { get; set; }

        public Contrato ContratoIdFkNavigation { get; set; }
        public Servico ServicoIdFkNavigation { get; set; }
        public Usuario UsuarioIdFkNavigation { get; set; }
    }
}
