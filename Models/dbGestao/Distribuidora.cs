using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Distribuidora
    {
        public Distribuidora()
        {
            Codigodistribuidora = new HashSet<Codigodistribuidora>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

        public ICollection<Codigodistribuidora> Codigodistribuidora { get; set; }
    }
}
