using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Usuario
    {
        public Usuario()
        {
            Comissaousuario = new HashSet<Comissaousuario>();
            Contatousuariocampanha = new HashSet<Contatousuariocampanha>();
            Emailmarketing = new HashSet<Emailmarketing>();
            Historiconovosservicos = new HashSet<Historiconovosservicos>();
            Permissaousuario = new HashSet<Permissaousuario>();
            Proposta = new HashSet<Proposta>();
            Solicitacaopropostas = new HashSet<Solicitacaopropostas>();
            Telefone = new HashSet<Telefone>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? Inativo { get; set; }
        public int RegrausuarioIdFk { get; set; }
        public string EmailPassword { get; set; }
        public int? FornecedorIdFk { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public bool? Comissionado { get; set; }
        public decimal? Comissao { get; set; }
        public int? CidadeIdFk { get; set; }
        public int? BairroIdFk { get; set; }
        public string Shortcuts { get; set; }
        public int? Cor { get; set; }

        public Bairro BairroIdFkNavigation { get; set; }
        public Cidade CidadeIdFkNavigation { get; set; }
        public Fornecedor FornecedorIdFkNavigation { get; set; }
        public Regrausuario RegrausuarioIdFkNavigation { get; set; }
        public ICollection<Comissaousuario> Comissaousuario { get; set; }
        public ICollection<Contatousuariocampanha> Contatousuariocampanha { get; set; }
        public ICollection<Emailmarketing> Emailmarketing { get; set; }
        public ICollection<Historiconovosservicos> Historiconovosservicos { get; set; }
        public ICollection<Permissaousuario> Permissaousuario { get; set; }
        public ICollection<Proposta> Proposta { get; set; }
        public ICollection<Solicitacaopropostas> Solicitacaopropostas { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
    }
}
