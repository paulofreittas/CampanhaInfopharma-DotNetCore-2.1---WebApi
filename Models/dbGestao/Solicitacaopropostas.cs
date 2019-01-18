using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Solicitacaopropostas
    {
        public Solicitacaopropostas()
        {
            Historicopropostas = new HashSet<Historicopropostas>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataGeracao { get; set; }
        public bool? Gerado { get; set; }
        public int? UltimoIdCliente { get; set; }
        public int? NumeroPropostas { get; set; }
        public int? UsuarioIdFk { get; set; }
        public bool? Enviado { get; set; }

        public Usuario UsuarioIdFkNavigation { get; set; }
        public ICollection<Historicopropostas> Historicopropostas { get; set; }
    }
}
