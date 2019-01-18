using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Configuracoesdinamicas
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string ValoresCombo { get; set; }
        public int? Tipo { get; set; }
        public string Grupo { get; set; }
    }
}
