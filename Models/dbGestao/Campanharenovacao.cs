using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Campanharenovacao
    {
        public Campanharenovacao()
        {
            Contatousuariocampanha = new HashSet<Contatousuariocampanha>();
        }

        public int IdPk { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int AnoReferencia { get; set; }

        public ICollection<Contatousuariocampanha> Contatousuariocampanha { get; set; }
    }
}
