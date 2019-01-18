using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Contrato = new HashSet<Contrato>();
            Origemlancamento = new HashSet<Origemlancamento>();
            Servico = new HashSet<Servico>();
            Telefone = new HashSet<Telefone>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public int? Situacao { get; set; }
        public int? Uf { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int? TipoPessoa { get; set; }
        public string Observacao { get; set; }
        public int? CidadeIdFk { get; set; }
        public int? BairroIdFk { get; set; }
        public string NomeContato { get; set; }
        public string Cpf { get; set; }
        public bool? Comissionado { get; set; }
        public decimal? Comissao { get; set; }
        public string RazaoSocial { get; set; }
        public bool? Representante { get; set; }
        public decimal? ValorRepasse { get; set; }
        public decimal? ValorMinimoMensalidade { get; set; }

        public Bairro BairroIdFkNavigation { get; set; }
        public Cidade CidadeIdFkNavigation { get; set; }
        public ICollection<Contrato> Contrato { get; set; }
        public ICollection<Origemlancamento> Origemlancamento { get; set; }
        public ICollection<Servico> Servico { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
