using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Tiposervico
    {
        public Tiposervico()
        {
            Servico = new HashSet<Servico>();
        }

        public int IdPk { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string NomeTipoServico { get; set; }
        public int? VigenciaServico { get; set; }
        public int? NumeroMeses { get; set; }
        public bool? ExecucaoUnica { get; set; }
        public string DescricaoTipoServico { get; set; }

        public ICollection<Servico> Servico { get; set; }
    }
}
