using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Responsavel
    {
        public Responsavel()
        {
            Legal = new HashSet<Legal>();
            Tecnico = new HashSet<Tecnico>();
            Telefone = new HashSet<Telefone>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? DataExpedicaoRg { get; set; }
        public int? OrgaoExpedidor { get; set; }
        public int? UfOrgaoExpedidor { get; set; }
        public int? Sexo { get; set; }
        public string Nacionalidade { get; set; }
        public string Profissao { get; set; }
        public int? EstadoCivil { get; set; }
        public string NumeroCr { get; set; }
        public int? UfCr { get; set; }
        public int ConselhoRegional { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public int? CidadeIdFk { get; set; }
        public int? BairroIdFk { get; set; }
        public int? Uf { get; set; }
        public DateTime? DataExpedicaoCrf { get; set; }
        public bool? ResponsavelContrato { get; set; }
        public bool? DataNascimentoConfirmada { get; set; }
        public bool? EmailConfirmado { get; set; }

        public Bairro BairroIdFkNavigation { get; set; }
        public Cidade CidadeIdFkNavigation { get; set; }
        public ICollection<Legal> Legal { get; set; }
        public ICollection<Tecnico> Tecnico { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
    }
}
