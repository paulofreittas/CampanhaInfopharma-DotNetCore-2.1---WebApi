﻿using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Anotacaoos
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? OrdemServicoIdFk { get; set; }
        public string Anotacao { get; set; }

        public Ordemservico OrdemServicoIdFkNavigation { get; set; }
    }
}
