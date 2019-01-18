using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Empresasoftwaregestao
    {
        public Empresasoftwaregestao()
        {
            Cliente = new HashSet<Cliente>();
            Formulariopbm = new HashSet<Formulariopbm>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Software { get; set; }
        public string Descricao { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Formulariopbm> Formulariopbm { get; set; }
    }
}
