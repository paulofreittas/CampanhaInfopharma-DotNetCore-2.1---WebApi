using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Propostaservico
    {
        public int Codigo { get; set; }
        public int Codproposta { get; set; }
        public int Codservico { get; set; }

        public Proposta CodpropostaNavigation { get; set; }
        public Servico CodservicoNavigation { get; set; }
    }
}
