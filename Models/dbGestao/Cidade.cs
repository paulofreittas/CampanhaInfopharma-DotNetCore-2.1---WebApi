using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Cidade
    {
        public Cidade()
        {
            Bairro = new HashSet<Bairro>();
            Cidadeabrangencia = new HashSet<Cidadeabrangencia>();
            Cliente = new HashSet<Cliente>();
            Fornecedor = new HashSet<Fornecedor>();
            Responsavel = new HashSet<Responsavel>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeCidade { get; set; }
        public int Uf { get; set; }

        public ICollection<Bairro> Bairro { get; set; }
        public ICollection<Cidadeabrangencia> Cidadeabrangencia { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
        public ICollection<Responsavel> Responsavel { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
