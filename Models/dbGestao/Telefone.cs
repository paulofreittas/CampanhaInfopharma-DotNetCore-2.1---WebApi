using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Telefone
    {
        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int Tipo { get; set; }
        public string Ddd { get; set; }
        public int? ClienteIdFk { get; set; }
        public int? FornecedorIdFk { get; set; }
        public int? ResponsavelIdFk { get; set; }
        public int? ContatoIdFk { get; set; }
        public string Contato { get; set; }
        public int? UsuarioIdFk { get; set; }
        public string Numero { get; set; }

        public Cliente ClienteIdFkNavigation { get; set; }
        public Contato ContatoIdFkNavigation { get; set; }
        public Fornecedor FornecedorIdFkNavigation { get; set; }
        public Responsavel ResponsavelIdFkNavigation { get; set; }
        public Usuario UsuarioIdFkNavigation { get; set; }
    }
}
