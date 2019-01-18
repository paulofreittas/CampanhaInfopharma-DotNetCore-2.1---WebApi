using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Premio
    {
        public Premio()
        {
            Tipoponto = new HashSet<Tipoponto>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? NumeroPontos { get; set; }
        public string UrlBanner { get; set; }

        public ICollection<Tipoponto> Tipoponto { get; set; }
    }
}
