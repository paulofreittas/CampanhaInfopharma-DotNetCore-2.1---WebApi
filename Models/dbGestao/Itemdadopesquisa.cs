using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Itemdadopesquisa
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Valor { get; set; }
        public int? DadoPesquisaIdFk { get; set; }
        public int? OrdemPesquisaIdFk { get; set; }

        public Dadopesquisa DadoPesquisaIdFkNavigation { get; set; }
        public Ordempesquisa OrdemPesquisaIdFkNavigation { get; set; }
    }
}
