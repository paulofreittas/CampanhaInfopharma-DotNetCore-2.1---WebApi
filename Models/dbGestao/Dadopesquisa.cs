using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Dadopesquisa
    {
        public Dadopesquisa()
        {
            Itemdadopesquisa = new HashSet<Itemdadopesquisa>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeDadoPesquisa { get; set; }
        public string DescricaoDadoPesquisa { get; set; }
        public int Ordem { get; set; }
        public int Tipo { get; set; }
        public string ValorCombo { get; set; }
        public int? PesquisaIdFk { get; set; }

        public Pesquisa PesquisaIdFkNavigation { get; set; }
        public ICollection<Itemdadopesquisa> Itemdadopesquisa { get; set; }
    }
}
