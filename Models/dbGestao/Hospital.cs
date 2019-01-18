using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Hospital
    {
        public Hospital()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeIncineradora { get; set; }
        public string Cidade { get; set; }
        public int? Uf { get; set; }
        public string EnderecoHospital { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
    }
}
