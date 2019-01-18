using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Servicodocumentos
    {
        public int Codigo { get; set; }
        public int Codservico { get; set; }
        public int Coddocumento { get; set; }

        public Documento CoddocumentoNavigation { get; set; }
        public Servico CodservicoNavigation { get; set; }
    }
}
