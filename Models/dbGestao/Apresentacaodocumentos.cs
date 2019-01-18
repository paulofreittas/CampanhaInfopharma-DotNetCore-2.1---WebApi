using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Apresentacaodocumentos
    {
        public int Codigo { get; set; }
        public int Codapresentacao { get; set; }
        public int Coddocumento { get; set; }

        public Apresentacao CodapresentacaoNavigation { get; set; }
        public Documento CoddocumentoNavigation { get; set; }
    }
}
