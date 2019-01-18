using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Documento
    {
        public Documento()
        {
            Anexodocumento = new HashSet<Anexodocumento>();
            Apresentacaodocumentos = new HashSet<Apresentacaodocumentos>();
            Servicodocumentos = new HashSet<Servicodocumentos>();
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int? Tipo { get; set; }
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public string TextoEmail { get; set; }
        public bool? EmailSeparado { get; set; }
        public bool? GerarPdf { get; set; }
        public string FooterMessage { get; set; }
        public bool? EnviarAposGerar { get; set; }
        public string Emails { get; set; }
        public string FromEmail { get; set; }
        public string Caminho { get; set; }

        public ICollection<Anexodocumento> Anexodocumento { get; set; }
        public ICollection<Apresentacaodocumentos> Apresentacaodocumentos { get; set; }
        public ICollection<Servicodocumentos> Servicodocumentos { get; set; }
    }
}
