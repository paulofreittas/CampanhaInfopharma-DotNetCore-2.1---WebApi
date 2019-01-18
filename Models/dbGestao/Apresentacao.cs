using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Apresentacao
    {
        public Apresentacao()
        {
            Apresentacaodocumentos = new HashSet<Apresentacaodocumentos>();
        }

        public int Codigo { get; set; }
        public string Nomecontato { get; set; }
        public string Nomedrogaria { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Dataretorno { get; set; }
        public string Horaretorno { get; set; }
        public string Cnpj { get; set; }
        public int Status { get; set; }

        public ICollection<Apresentacaodocumentos> Apresentacaodocumentos { get; set; }
    }
}
