using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Ordempesquisa
    {
        public Ordempesquisa()
        {
            Itemdadopesquisa = new HashSet<Itemdadopesquisa>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeOrdem { get; set; }
        public bool? Sucesso { get; set; }
        public string Observacao { get; set; }
        public int? PesquisaIdFk { get; set; }
        public DateTime? DataOrdem { get; set; }
        public int? ClienteIdFk { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Pesquisa PesquisaIdFkNavigation { get; set; }
        public ICollection<Itemdadopesquisa> Itemdadopesquisa { get; set; }
    }
}
