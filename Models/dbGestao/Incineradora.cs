using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Incineradora
    {
        public Incineradora()
        {
            Coleta = new HashSet<Coleta>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeIncineradora { get; set; }
        public string Cidade { get; set; }
        public int? Uf { get; set; }
        public string TratamentoIncineradora { get; set; }
        public string Veiculo { get; set; }

        public ICollection<Coleta> Coleta { get; set; }
    }
}
