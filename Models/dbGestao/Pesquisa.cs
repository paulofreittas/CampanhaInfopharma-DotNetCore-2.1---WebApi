using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Pesquisa
    {
        public Pesquisa()
        {
            Dadopesquisa = new HashSet<Dadopesquisa>();
            Ordempesquisa = new HashSet<Ordempesquisa>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomePesquisa { get; set; }
        public string DescricaoPesquisa { get; set; }
        public DateTime? DataValidade { get; set; }
        public int? GrupoOrdemIdFk { get; set; }

        public Grupoordem GrupoOrdemIdFkNavigation { get; set; }
        public ICollection<Dadopesquisa> Dadopesquisa { get; set; }
        public ICollection<Ordempesquisa> Ordempesquisa { get; set; }
    }
}
