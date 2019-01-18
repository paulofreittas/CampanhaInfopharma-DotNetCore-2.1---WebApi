using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Logalteracoessistema
    {
        public int IdPk { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string Motivo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string UserName { get; set; }
        public int? Codigo { get; set; }
    }
}
