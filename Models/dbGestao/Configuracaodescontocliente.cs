using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Configuracaodescontocliente
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public decimal? PercentualDescontoMensalidade { get; set; }
        public decimal? PercentualDescontoAdesao { get; set; }
        public int ClienteIdFk { get; set; }
        public DateTime? DataPrimeiroBoleto { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
    }
}
