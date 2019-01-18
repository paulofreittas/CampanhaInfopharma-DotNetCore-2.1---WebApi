using System;
using System.Collections.Generic;

namespace CampanhaInfopharma.Models.dbGestao
{
    public partial class Regracontratoparcela
    {
        public int Codigo { get; set; }
        public int? Id { get; set; }
        public int? Parcela { get; set; }
        public string Descricao { get; set; }
        public int? Codregracontrato { get; set; }
        public int? Codprocesso { get; set; }
        public int? Tipo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? DadoProcessoIdFk { get; set; }

        public Processo CodprocessoNavigation { get; set; }
        public Regracontrato CodregracontratoNavigation { get; set; }
        public Dadoprocesso DadoProcessoIdFkNavigation { get; set; }
    }
}
