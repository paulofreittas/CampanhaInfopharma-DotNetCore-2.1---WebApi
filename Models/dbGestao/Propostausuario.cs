using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Propostausuario
    {
        public int Codigo { get; set; }
        public int Codproposta { get; set; }
        public Guid Coduser { get; set; }

        public Proposta CodpropostaNavigation { get; set; }
        public AspnetUsers CoduserNavigation { get; set; }
    }
}
