using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Bairro
    {
        public Bairro()
        {
            Cliente = new HashSet<Cliente>();
            Fornecedor = new HashSet<Fornecedor>();
            Responsavel = new HashSet<Responsavel>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeBairro { get; set; }
        public int? CidadeIdFk { get; set; }

        public Cidade CidadeIdFkNavigation { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
        public ICollection<Responsavel> Responsavel { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
